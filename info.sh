#!/bin/bash

# Print current date and time
printf "Current date and time: "
date

# Print current logged-in users and their terminal sessions
printf "Logged-in users:\n"
w

# Print system information
printf "System information:\n"
printf "Operating system: "
uname -o
printf "Kernel version: "
uname -r

# Print uptime
printf "Uptime: "
uptime