for file in `\find ./src -maxdepth 1 -name '*.wat'`; do
  name=${file##*/}
  wat2wasm $file -o "./dist/${name/.wat/.wasm}"
done
