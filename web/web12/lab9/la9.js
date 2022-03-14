const express = require("express");
// создаем приложение
const app = express();
 
// устанавливаем обработчик для маршрута "/"
app.get("/", function(request, response){
 
    response.end();
});
// начинаем прослушивание подключений на 3000 порту
app.listen(3000);