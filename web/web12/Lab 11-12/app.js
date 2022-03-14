
//чтение файла
var fs = require('fs');
// подключение express
const express = require("express");
const app = express();
app.set("view engine", "hbs");
const hbs = require("hbs");
const bodyParser = require("body-parser");
const urlencodedParser = bodyParser.urlencoded({ extended: false });

// устанавливаем настройки для файлов layout
hbs.registerPartials(__dirname + "/views/partials");


var fileText = fs.readFileSync(__dirname + "/views/product_item.hbs", 'utf8');
var product_item_template = hbs.compile(fileText);

fileText = fs.readFileSync(__dirname + "/views/basket_item.hbs", 'utf8');
var basket_item_template = hbs.compile(fileText);


//список товаров

fileText = fs.readFileSync(__dirname + '/public/json/items.json');

var products = JSON.parse(fileText);
//корзина
fileText = fs.readFileSync(__dirname + '/public/json/basket.json');
var basket = JSON.parse(fileText);


app.use(express.static(__dirname + '/public'));

app.listen(3000, "127.0.0.1", function () {
    console.log("Сервер начал прослушивание запросов на порту 3000");
});

//главная страница - список товаров
app.get("/", function (request, response) {
    response.redirect("products");
});
//список товаров
app.use("/products", function (request, response) {
    response.render(__dirname + "/views/products.hbs");
});
//корзина
app.use("/basket", function (request, response) {
    let total = 0;
    for (i = 0; i < basket['items'].length; i++) {
        basket['items'][i].totalPrice = basket['items'][i].count * basket['items'][i].price;
        total += basket['items'][i].totalPrice;
    }

    response.render(__dirname + "/views/basket.hbs", {
        total: total
    });
});

//подробная информация о товаре №id
app.use("/item/:id", function (request, response) {
    let id = request.params["id"];
    let product = products[id];
    response.render(__dirname + "/views/item_page.hbs", {
        name: product.name,
        desc: product.desc,
        img: product.img,
        price: product.price,
        item_id: id
    }
    );
});
//добавление товара #id в корзину
app.post("/add_basket/:id", urlencodedParser, function (request, response) {
    let id = request.params["id"];
    let product = { ...products[id] };
    product.id = parseInt(id);
    product.count = parseInt(request.body.count);

    let isMeet = false;
    for (i = 0; i < basket['items'].length; i++) {
        if (basket['items'][i].id == id) {
            basket['items'][i].count = product.count + basket['items'][i].count;
            isMeet = true;
            break;
        }

    }

    if (!isMeet)
        basket['items'].push(product);

    fs.writeFileSync(__dirname + '/public/json/basket.json', JSON.stringify(basket));
    response.redirect("/basket");
});
//очистка козины
app.post("/clear_basket", urlencodedParser, function (request, response) {
    basket = JSON.parse(`{"items":[]}`);
    fs.writeFileSync(__dirname + '/public/json/basket.json', JSON.stringify(basket));
    response.redirect("/basket");
});
//оформить заказ
app.post("/make_order/", urlencodedParser, function (request, response) {

    let user = request.body.user_name
    let tel = request.body.user_tel

    let total = 0;
    for (i = 0; i < basket['items'].length; i++) {
        basket['items'][i].totalPrice = basket['items'][i].count * basket['items'][i].price;
        total += basket['items'][i].totalPrice;
    }

    if (total != 0) {
        basket[`TOTAL`] = total;
        basket[`USER_NAME`] = user;
        basket[`TELEPHONE`] = tel;
        now = new Date();
        let dir = getOrderDir(now);
        let file = getOrderFile(now);
        if (!fs.existsSync(__dirname + dir))
            fs.mkdirSync(__dirname + dir, { recursive: true });
        fs.writeFileSync(__dirname + dir + file, JSON.stringify(basket), fs.WeFileO);
        console.log(`ЗАКАЗ ${__dirname + dir + file} добавлен:`);
        console.log(basket);
        basket = JSON.parse(`{"items":[]}`);
        fs.writeFileSync(__dirname + '/public/json/basket.json', JSON.stringify(basket));

        response.send(`<nav style="text-align: center;">
        <a href="/products">Список товаров</a> | <a href="/basket">Корзина</a>
       </nav><h1>Ожидайте звонка..</h1>`)
    }
    else {
        response.send(`<nav style="text-align: center;">
        <a href="/products">Список товаров</a> | <a href="/basket">Корзина</a>
       </nav><h1>Корзина уже пуста</h1>`);
    }
});

function getOrderDir(date) {
    return '/ORDERS/' + date.toDateString() + '/';
}
function getOrderFile(date) {
    hour = date.getHours();
    min = date.getMinutes();
    sec = date.getSeconds()
    return `${hour}hour_${min}min_${sec}sec.json`;
}




hbs.registerHelper('table', function () {
    let res = "";
    len = products.length;
    if (len == 0) {
        res = "<h1>Товаров Нет!</h1>"
    }
    for (j = 0; j <= len / 4; j++) {
        for (i = 0; i < 4 && i + 4 * j < len; i++) {
            var product = products[i + 4 * j]
            var context = {
                name: product.name,
                desc: product.desc,
                img: product.img,
                price: product.price,
                href: "/item/" + (i + 4 * j)
            }
            var html = product_item_template(context);
            res += html;
        }
    }
    return new hbs.SafeString(res);
});

hbs.registerHelper('basket', function () {
    var res = "";
    len = basket['items'].length;
    if (len == 0) {
        res = `<h1 id="basket_empty">Корзина пуста!</h1>`
    }
    for (j = 0; j <= len / 4; j++) {
        for (i = 0; i < 4 && i + 4 * j < len; i++) {
            var product = basket['items'][i + 4 * j]
            var context = {
                name: product.name,
                img: product.img,
                price: product.price,
                count: product.count,
                total: product.price * product.count,
                href: "/item/" + (product.id)
            }
            var html = basket_item_template(context);
            res += html;
        }
    }
    return new hbs.SafeString(res);
});
