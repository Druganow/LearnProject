let param1 = process.argv[2];
let param2 = process.argv[3];
const http = require("http");
http.createServer(function(request,response){
    response.write("<!DOCTYPE html>");
    response.write("<html>");
    response.write("<head>");
    response.write("<title>Лаб 9</title>");
    response.write("<meta charset=\"utf-8\" />");
    response.write("</head>");
    response.write("<body><h2>Мини-сайт из одной страницы с использованием модуля express</h2>");
	response.write("<div>Текст страницы, который не имеет значения</div>");
	response.write("<div>Передаваемый парамерт №1:  " + param1+"</div>")
	response.write("<div>Передаваемый парамерт №2:  " + param2+"</div>")
	response.write("</body>");
    response.write("</html>");
    response.end();
     
}).listen(3000, "127.0.0.1",function(){
    console.log("Сервер начал прослушивание запросов на порту 3000");
});