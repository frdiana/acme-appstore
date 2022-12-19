cd ../../
major="0"
minor="0"
revision="2"
imageVersion="$major.$minor.$revision"
az acr login --name frdianaacr
docker build -t frdianaacr.azurecr.io/acmeappstore-movies:v$imageVersion -f movies/src/Dockerfile .
docker push frdianaacr.azurecr.io/acmeappstore-movies:v$imageVersion