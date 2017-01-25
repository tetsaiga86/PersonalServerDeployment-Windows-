const fs = require('fs');

var options = {
    year: 'numeric', month: 'numeric', day: 'numeric',
    hour: 'numeric', minute: 'numeric', second: 'numeric',
    hour12: false
}

log = {
    info: function () {
        const logString = new Date().toLocaleString('en-US', options) + ': ' +
            Array.prototype.slice.call(arguments).join(', ');
        fs.appendFileSync('server.log', logString + '\n');
    }
}

module.exports = log;
