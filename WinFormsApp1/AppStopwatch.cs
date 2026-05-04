using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    //Implementation of the IStopwatch interface, defines the behavior of the stopwatch
    class AppStopwatch : IStopwatch
    {
        //The time when the stopwatch was started, used to calculate the elapsed time
        private DateTime _startTime;
        //The total elapsed time, used to store the elapsed time when the stopwatch is stopped
        private TimeSpan _elapsed;
        //Indicates whether the stopwatch is currently running
        private bool _isRunning;

        public TimeSpan Elapsed
        {
            get {

                //If running, calculate the elapsed time by adding the time since the last start to the previously stored elapsed time
                if (_isRunning)
                    return _elapsed + (DateTime.Now - _startTime);
                //If not running, return the stored elapsed time
                return _elapsed;
            }
        }
        public void Start()
        {
            if(_isRunning) return;
            //Start time even when starting from a stop
            _startTime = DateTime.Now;
            _isRunning = true;
        }
        public void Stop()
        {
            if (!_isRunning) return;
            //Accumalate stop time
            _elapsed += DateTime.Now - _startTime;
            _isRunning = false;
        }
        public void Reset()
        {
            //Set elapsed time to zero
            _elapsed = TimeSpan.Zero;
            _isRunning= false;
        }

    }
}
