var fs = require('fs');
var https = require('https');
const log = require('./logger/logger');
var express = require('express');
var apiRouter = require('./routers/apiRouter');
const formidable = require('express-formidable');
var app = express();
var port = parseInt(process.argv[2]);

function runServer(err, data) {
  if (err) {
    log.info(err);
    throw err;
  }
  var options = {
    pfx: data
  };

  app.use(formidable());

  app.get('/', function (req, res) {
    res.send('Hello World!');
  });

  app.use('/api', apiRouter);

  https.createServer(options, app).listen(port, function () {
    log.info('The server is running on port ' + port);
    console.log('Example app listening on port ' + port);
  });

}

fs.readFile('./serverApi/server.pfx', runServer);
