Miguel Ros Honda

P1) the -n is a command used to make my own personalised commit instead of it being done automatically
P2) the project file returns to the state of the specified commit, wiping out any uncommited changed.
P3) 
	- Revert keeps history intact while reset deletes commits from history
	- Revert does not modify the working directory directly while reset resets the working directory to the state of a previous commit
	- Revert is safer for shared branches
	- Reset is faster since we do not need to do extra commits