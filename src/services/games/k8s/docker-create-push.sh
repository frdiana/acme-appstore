cd ../../
major="0"
minor="0"
revision="2"
imageVersion="$major.$minor.$revision"
az acr login --name frdianaacr
docker build -t frdianaacr.azurecr.io/acmeappstore-games:v$imageVersion -f games/AcmeAppStore.Games/Dockerfile .
docker push frdianaacr.azurecr.io/acmeappstore-games:v$imageVersion