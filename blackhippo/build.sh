#! /bin/sh

docker build -t blackhippo --file DockerFile .
docker run -p 5000:5000 blackhippo