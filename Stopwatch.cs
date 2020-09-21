using System;

namespace ultimate_csharp_mastery
{
    public class Stopwatch
    {
        public TimeSpan Duration { get { return _stop - _start; } private set { } }

        private DateTime _start;
        private DateTime _stop;
        private bool _isStarted;
        private bool _isStopped;

        public void Start()
        {
            if (_isStarted)
                throw new InvalidOperationException("Stopwatch cannot be started before stopped");

            _start = DateTime.Now;
            _isStarted = true;
            _isStopped = false;
        }

        public void Stop()
        {
            if (_isStopped)
                throw new InvalidOperationException("Stopwatch cannot be stopped before started");

            _stop = DateTime.Now;
            _isStopped = true;
            _isStarted = false;
        }
    }
}