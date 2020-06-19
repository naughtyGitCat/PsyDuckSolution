#!/bin/bash

function f_init {
 gPackageName="PsyDuckCommon"
 gDotNet="/usr/local/share/dotnet/dotnet"
 gNugetKey="oy2foi6lyppdciiwg5kacn5lalwfahkebkpk3734gehlly"
}

function f_pack {
  ${gDotNet} pack
}

function f_find_latest {
    local rawArray=($(ls -t "$PWD"/bin/Debug/${gPackageName}*))
    # echo ${rawArray[@]}
    gLastPackageFile=${rawArray[0]}
}

function f_push {
    echo "###################Now publish $(basename ${gLastPackageFile}) to nuget#####################"
    ${gDotNet} nuget push ${gLastPackageFile} -k ${gNugetKey} -s https://api.nuget.org/v3/index.json
}

f_init
f_pack
f_find_latest
f_push
