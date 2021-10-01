using System;

namespace DesignPatterns.Logger
{
    public class LogBuilder
    {
        private  Log _log = new Log();
        private bool _isEmpty = true;
        private readonly ILoggerWriter loggerWriter;

        public LogBuilder(ILoggerWriter loggerWriter)
        {
            this.loggerWriter = loggerWriter ?? throw new ArgumentNullException(nameof(loggerWriter));
        }
        public LogBuilder Assign(Action action)
        {
            action.Invoke();
            this._isEmpty = false;
            return this;
        }

        public LogBuilder WithLevel(int level) => this.Assign(()=>this._log.Level = level);
        public LogBuilder WithMessage(string message) => this.Assign(() => this._log.Message= message);
        public LogBuilder WithData(object data) => this.Assign(() => this._log.Data = data);
        public LogBuilder WithContext(object context) => this.Assign(() => this._log.Context = context);
        public LogBuilder WithException(Exception exception) => this.Assign(() => this._log.Exception = exception);

        public void Finish()
        {
            this.DoWriteLog();
        }

        private void DoWriteLog()
        {
            if (!this._isEmpty)
            {
                this.loggerWriter.WriteLog(
                    this._log.Level,
                    this._log.Message,
                    this._log.Data,
                    this._log.Context,
                    this._log.Exception);

                this._isEmpty = true;
                this._log = new Log();
            }
        }      
    }
}
