var express = require('express');
var apiRouter = require('./routers/apiRouter');
const formidable = require('express-formidable');
const log = require('simple-node-logger').createSimpleFileLogger('server.log');
var app = express();
var port = 3000;

app.use(formidable());

app.get('/', function (req, res) {
  res.send('Hello World!');
});

app.use('/api', apiRouter);

app.listen(port, function () {
    log.info('The server is running on port ' + port + ' ', new Date().toJSON());
  console.log('Example app listening on port 3000!');
});
