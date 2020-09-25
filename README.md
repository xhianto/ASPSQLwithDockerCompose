# TestASPSQL
Test for ASP and SQL with docker-compose

Install docker-compose (https://docs.docker.com/compose/install/)
Docker is needed for docker-compose.

If there is a connection with api.nuget.org problem during the build of an dockerimage for the website.
Then you might need to add a dns to your daemon.json in /etc/docker/, it did work for me.
If there is no such file, then make a new daemon.json with
--------------------------------
{
  "dns": ["8.8.8.8", "8.8.4.4"]
}
--------------------------------
You can use your own dns instead of google's, if you prefer
