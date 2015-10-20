var http = require('http');
var express = require('express');
var bodyParser = require('body-parser');

var port = process.env.port || 1337;

var app = express();
app.use(bodyParser());

app.get('/', function (requrest, response) {
    response.send("Hello, I am Gabe.")
});

app.listen(port);