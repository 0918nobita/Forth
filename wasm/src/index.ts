import 'wasm-ts';

const memory = new WebAssembly.Memory({ initial: 1 });

const importObj = {
  console: {
    log: console.log
  },
  js: {
    mem: memory
  }
};

(async () => {
  const resultObj = await WebAssembly.instantiateStreaming(fetch('example.wasm'), importObj);
  resultObj.instance.exports.add(2, 5);
  resultObj.instance.exports.interpret();
  console.log(resultObj.instance.exports.factorial(4));
  const typedArray = new Uint8Array(memory.buffer);
  for (let i = 2; i < 10; i++) typedArray[i] = 3;
  console.log(memory);
})();
