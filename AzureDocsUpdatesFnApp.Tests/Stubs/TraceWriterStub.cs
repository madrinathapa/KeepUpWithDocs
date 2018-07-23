﻿using Microsoft.Azure.WebJobs.Host;
using System.Collections.Generic;
using System.Diagnostics;

namespace AzureDocsUpdatesFnApp.Tests.Stubs
{
    public class TraceWriterStub : TraceWriter
    {
        protected TraceLevel _level;
        protected List<TraceEvent> _traces;

        public TraceWriterStub(TraceLevel level = TraceLevel.Verbose) : base(level)
        {
            _level = level;
            _traces = new List<TraceEvent>();
        }

        public override void Trace(TraceEvent traceEvent)
        {
            _traces.Add(traceEvent);
        }

        public List<TraceEvent> Traces => _traces;
    }
}
