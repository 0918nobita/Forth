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

  export declare class Global {
    value: any;
    constructor(descriptor: { value: 'i32' | 'i64' | 'f32' | 'f64', mutable?: boolean }, value: any);
    toString(): 'WebAssembly.Global';
    valueOf(): any;
  }

  export declare class Instance {
    /**
     * Returns an object containing as its members all the functions exported from the WebAssembly module instance,
     * to allow them to be accessed and used by JavaScript.
     */
    readonly exports: { [K: string]: Function };

    /**
     * @param module The `WebAssembly.Module` object to be instantiated.
     * @param importObject An object containing the values to be imported into newly-created `Instance`,
     * such as functions or `WebAssembly.Memory` objects.
     * There must be one matching property for each declared import of `module` or else a WebAssembly.LinkError is thrown.
     */
    constructor(module: Module, importObject?: object);

    /**
     * Increases the size of the memory instance by a specified number of WebAssembly pages.
     * @param pages The number of WebAssembly pages you want to grow the memory by (each one is 64KiB in size) .
     * @returns The previous size of the memory.
     */
    grow(pages: number): number;
  }

  /**
   * A memory created by JavaScript or in WebAssembly code will be accessible and mutable
   * from both JavaScript and WebAssembly.
   */
  export declare class Memory {
    /**
     * An accessor property that returns the buffer contained in the memory.
     */
    buffer: ArrayBuffer;

    /**
     * Creates a new `Memory` object which is a resizable ArrayBuffer
     * that holds the raw bytes of memory accessed by a WebAssembly `Instance`.
     */
    constructor(memoryDescriptor: { initial: number; maximum?: number; });
  }

  export declare class Table {
    /** the length of the table */
    length: number;

    constructor(tableDescriptor: { element: string; initial: number; maximum?: number; });

    /**
     * Retrives a function reference stored at a given index.
     * @param index The index of the function reference you want to retrive.
     * @returns a function reference — this is exported WebAssembly function,
     * a JavaScript wrapper for an underlying wasm function.
     */
    get(index: number): Function;

    /**
     * Increases the size of the Table instance by a specified number of elements.
     * @param elements The number of elements you want to grow the table by.
     * @returns The previous length of the table.
     */
    grow(elements: number): number;

    /**
     * Mutates a reference stored at a given index to a difference value.
     * @param index The index of the function reference you want to mutate.
     * @param value The value you want to mutate the reference to. This must be an exported WebAssembly function,
     * a JavaScript wrapper for underlying wasm function.
     */
    set(index: number, value: Function): void;
  }

  /**
   * Indicates an error during WebAseembly decoding or validation.
   */
  export declare class CompileError extends Error {}

  /**
   * Indicates an error during module instantiation.
   */
  export declare class LinkError extends Error {}

  /**
   * The type is thrown whenever WebAssembly specifies a trap.
   */
  export declare class RuntimeError extends Error {}
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
