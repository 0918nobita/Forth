namespace WebAssembly {
  export declare class Module {
    /**
     * Returns a copy of the contents of all custom sections in the given module with the given string name.
     * @param module The `WebAssembly.Module` object whose custom sections are being considered.
     * @param sectionName The string name of the desired custom section.
     */
    static customSections(module: Module, sectionName: string): ArrayBuffer;

    /**
     * Returns an array containing descriptions of all the declared exports of the given `Module`.
     * @param module A `WebAssembly.Module` object.
     * @returns An array containing objects representing the exported functions of the given module.
     */
    static exports(module: Module): object;

    /**
     * Returns an array containing descriptions of all the declared imports of the given `Module`.
     * @param module A `WebAssembly.Module` object.
     * @returns An array containing objects representing the imported functions of the given module.
     */
    static imports(module: Module): object;
  
    toString(): 'WebAssembly.Module';
  }
}

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
