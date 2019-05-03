const importObj = {
  console: {
    log: console.log
  }
};

WebAssembly.instantiateStreaming(fetch('logger.wasm'), importObj).then(obj => {
  obj.instance.exports.logIt();
});
