#! /bin/sh

docker build -t blackhippo --file DockerFile .
docker run -d -p 5000:5000 -u 33 blackhippo
