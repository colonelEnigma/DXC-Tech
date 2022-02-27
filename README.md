# DXC-Tech
DXC Coding Challenge

This exercise requires you to write a C# program to get it to display the first n Fibonacci numbers.
Note: The Fibonacci Sequence is the series of numbers: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, . . .

# Setup for Compile, run C# in Ubuntu 20.04 via Installing "MONO"
(Mono is a software platform designed to allow developers to easily create cross platform applications part of the . NET Foundation.)
(more info: https://www.mono-project.com/)

sudo apt install gnupg ca-certificates

sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF

echo "deb https://download.mono-project.com/repo/ubuntu stable-focal main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list

sudo apt update
    
sudo apt install mono-complete


# The command to compile the code -
mcs -out:TestFibonacci.exe TestFibonacci.cs

# The command to execute the .exe file -
mono TestFibonacci.exe