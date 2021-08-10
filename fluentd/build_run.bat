@ECHO OFF

cls

ECHO Building fluentd Image...

docker build -t fluentd-example:latest ./

ECHO Finished building image

ECHO Spinning up a fluentd-example container...

docker run -it --rm --name cn-fluentd-example -p 24444:24444 fluentd-example:latest