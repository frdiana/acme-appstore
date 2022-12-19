cd ../../
major="0"
minor="0"
revision="6"
imageVersion="$major.$minor.$revision"
az acr login --name frdianaacr
docker build -t frdianaacr.azurecr.io/acmeappstore-books:v$imageVersion -f books/src/Dockerfile .
docker push frdianaacr.azurecr.io/acmeappstore-books:v$imageVersion