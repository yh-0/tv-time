#!/bin/bash

declare -a shows

while read -r line || [[ -n "$line" ]]
do
    length="$(./"$GET_TVSHOW_TOTAL_LENGTH_BIN" "$line")"

    tmp1=$(echo "$length" | xxd -p)

    tmp2=${tmp1::-4}
    
    var="$tmp2$line"

    shows+=("$var")
done

echo "${#shows[@]}"

printf '%s\n' "${shows[@]}"