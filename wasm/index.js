const memory = new WebAssembly.Memory({ initial: 1 });

const importObj = {
  console: {
    log: console.log
  },
  js: {
    mem: memory
  }
};

WebAssembly.instantiateStreaming(fetch('example.wasm'), importObj).then(obj => {
  obj.instance.exports.add(2, 5);
});

console.log(memory);
