import { WebAssembly } from 'wasm-ts';

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
  console.log(memory);
  console.log(resultObj.instance.exports.factorial(4));
})();
