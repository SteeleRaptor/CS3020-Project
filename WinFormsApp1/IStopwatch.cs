using System;
//Interface for the stopwatch, defines the methods and properties that a stopwatch should have
public interface IStopwatch
{
	void Start();
	void Stop();
	void Reset();
    //getter for the elapsed time, returns a TimeSpan object representing the elapsed time since the stopwatch was started
    TimeSpan Elapsed { get; }

}
