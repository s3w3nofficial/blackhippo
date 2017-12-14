#!/bin/bash

sudo -u www-data kill $(cat /tmp/blackhippo.pid)
sudo -u www-data rm /tmp/blackhippo.pid
sudo -u www-data git pull
sudo -u www-data start-stop-daemon --start --background -m --pidfile /tmp/blackhippo.pid --exec /usr/libexec/blackhippo --
