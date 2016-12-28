var root = 'c:/users/kyle/music/';
var fs = require('fs');
var test = 'C:/Users/Kyle/Downloads/';

function _isDescendantOfRoot (path) {
  try {
    var strippedPath = path.match(root);
    if (strippedPath[0] != root || path === root) return false;
    return true;
  } catch (e) {
    console.error(e);
    return false;
  }
}
function _isWritablePath(path) {
  if(_isDescendantOfRoot(path) || path === root) return true;
  return false;
}
function _isDeletablePath (path) {
  if(_isDescendantOfRoot(path)) return true;
  return false;
}
function _isReadablePath(path) {
  if(_isDescendantOfRoot(path) || path === root) return true;
  return false;
}

function _isPathEqual(path1, path2) {
  var path1Stat = fs.statSync(path1);
  var path2Stat = fs.statSync(path2);

  if (path1Stat.ino === path2Stat.ino) return true;
  return false;
}
