@ECHO OFF

cls

ECHO Building TwelveFactorAppLoggingExample.Api Image...

docker build -t twelvefactorapploggingexampleapi:latest ./

ECHO Finished building image

ECHO Spinning up a TwelveFactorAppLoggingExample.Api container...

docker run --rm --name cn-twelvefa-logging-example-api --log-driver=fluentd --log-opt tag="docker.{{.ImageName}}" --log-opt fluentd-address=172.17.0.2:24224 -p 3000:80 twelvefactorapploggingexampleapi
