# MiniOS-Simulator

# About
The following program is a small simulation of an operative system made for my OS class. It features basic processing jobs flow with the Round Robin policy and RAM workflow with the least used policy.

# Flow of the processes
* 1.- Theres a chance that a new process is created, once that happens...
* 2.- The new process moves to the "New" queue and once "Running" is unoccupied it moves to Ready.
* 3.- Once in Ready, each process will go into "Running" one by one, following the Round Robin Policy. In the Running section, the process can either go to waiting disk to grab a new memory page or to waiting I/O if the probability of needing to use the printer arose. 
* 4.- The processes will start cycling around Running and will change its memory page if the probability deems it so (If they change they will be sent to waiting disk again)
* 5.- The process will eventually finish and move to the Terminated table

# Important tables
* PCB: Keeps a track of all created processes with its characteristics.
* TCP: Keep a track of the memory pages of each process (limited to 6 pages each to keep it simple)
* Terminated: Shows the finished processes with their different results

# Parameters
To make this MiniOS a bit more dynamic, the user can modify certain parameters to make the processess and the memory act differently. Refer to the "Help" tab in the program to get a description about each.

Note: It sounds a bit more complicated that it really is but you will get a clear idea once you start running the program

