# TestASPSQL
Test for ASP and SQL with docker-compose

## Installation
- Clone this repo to your local machine using `git clone https://github.com/xhianto/ASPSQLwithDockerCompose
- Docker and docker-compose is needed
- For installation of docker-compose visit (https://docs.docker.com/compose/install/)
- Once repos is cloned go inside the TestASPSQL directory
```shell
$ docker-compose up
CTRL+C to exit
```
```shell
"Or run in detached mode"
$ docker-compose up -d

"To stop the containers"
$ docker-compose down
```

## Troubleshoot
- **Connection problem with 'api.nuget.org' during the build of the dockerimage for the website in Linux.**
  - You might need to add a dns to your 'deamon.json' in '/ect/docker/'. If there is no such file, then make a new 'daemon.json' in '/etc/docker/' with
    ```shell
    {
      "dns": ["8.8.8.8", "8.8.4.4"]
    }
    ```
    You can use your own dns instead of google's, if you prefer
