const http = require("http");
const fs = require("fs");

http.createServer(function(request, response){
    
    response.setHeader("Content-Type", "text/html; charset=utf-8;");

    let header = "Заголовок";
    let about = "Содержание";
    if(request.url === "/home" || request.url === "/"){
        header = "<h2>Главная</h2>";
		about="<div>А Вы знали, что:<div>"+
		"<div>При завоевании Вейнсберга в 1140 году король Германии Конрад III</div>"+
		"<div>позволил покинуть разрушенный город женщинам и унести в руках то,</div>"+
		"<div>что они пожелают. Женщины вынесли на плечах своих мужей.</div>"+
		"<p><a href=/about>О себе</a></p>"+
		"<p><a href=/contact>Контакты</a></p>";
    }
    else if(request.url == "/about"){
       header = "<h2>О себе</h2>";
	   about="<div>Даже не знаю, что тут можно написать"+
		"<div>А Вы знали, что:<div>"+
		"<div>Автор этой работы собирался поступать на госуправление</div>"+
		"<div>но не прошел, ибо завалил математику...вот ирония</div>"+
		"<p><a href=/home>На главную</a></p>"+
		"<p><a href=/сontact>Контакты</a></p>";
    }
    else if(request.url == "/contact"){
       header = "<h2>Контакты</h2>";
	   about="<div><img src=https://sun9-65.userapi.com/impg/c857228/v857228231/cb720/oaIPTzzJoTI.jpg?size=447x568&quality=96&sign=384b3156d4411905890e9657251a52e5&type=album></img>"+
		"<p><a href=/home>На главную</a></p>"+
		"<p><a href=/about>О себе</a></p>";
    }
    else{
       header = "<h2>Not found</h2>";
	   about="";
    }

    fs.readFile("index_lab10.html", "utf8", function(error, data){
        data = data.replace("{header}", header);
		data = data.replace("{about}", about);
        response.end(data);
    });

}).listen(3000);