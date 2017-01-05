var express = require('express');
const log = require('./logger/logger');
var apiRouter = require('./routers/apiRouter');
const formidable = require('express-formidable');
var app = express();
var port = parseInt(process.argv[2]);


app.use(formidable());

app.get('/', function (req, res) {
  res.send('Hello World!');
});

app.use('/api', apiRouter);

app.listen(port, function () {
    log.info('The server is running on port ' + port);
  console.log('Example app listening on port ' + port);
});
