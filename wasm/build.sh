cd ./src

for file in `\find . -maxdepth 1 -name '*.wat'`; do
  wat2wasm $file -o "../dist/${file/.wat/.wasm}"
done

cd ..
