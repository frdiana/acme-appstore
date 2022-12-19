cd ../../
major="0"
minor="0"
revision="2"
imageVersion="$major.$minor.$revision"
az acr login --name frdianaacr
docker build -t frdianaacr.azurecr.io/acmeappstore-apps:v$imageVersion -f apps/src/Dockerfile .
docker push frdianaacr.azurecr.io/acmeappstore-apps:v$imageVersion