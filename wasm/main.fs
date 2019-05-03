( Open )
S" output.txt" w/o create-file throw Value fd-out

( Write )
S" test" fd-out write-line

( Close )
fd-out close-file
