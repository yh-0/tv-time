#!bin/bash

mapfile -t shows
declare -A show_lengths

for show in "${shows[@]}"
do
    show_lengths[$show]=$(./"$GET_TVSHOW_TOTAL_LENGTH_BIN" "$show") 
done

for key in "${!show_lengths[@]}"
do 
    echo "$key"
    echo "${show_lengths[$key]}"
done