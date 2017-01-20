var fs = require('fs');
var https = require('https');
var options = {
  pfx: fs.readFileSync('server.pfx')
};
var express = require('express');
const log = require('./logger/logger');
var apiRouter = require('./routers/apiRouter');
const formidable = require('express-formidable');
var app = express();
var port = parseInt(process.argv[2]);
for (var i = 0; i < process.argv.length; i++) {
  log.info(process.argv[i]);
}

app.use(formidable());

app.get('/', function (req, res) {
  res.send('Hello World!');
});

app.use('/api', apiRouter);

https.createServer(options, app).listen(port, function () {
  log.info('The server is running on port ' + port);
  console.log('Example app listening on port ' + port);
});
