#!/bin/bash

rmnl ()
{
    tmp1=$(echo "$1" | xxd -p)
    tmp2=${tmp1::-4}
    echo "$tmp2" | xxd -r -p
}

fun ()
{
    length="$(./"$GET_TVSHOW_TOTAL_LENGTH_BIN" "$1")"
    echo "$1"
    rmnl "$length"
}

while read -r line || [[ -n "$line" ]]
do
    fun "$line" &
done