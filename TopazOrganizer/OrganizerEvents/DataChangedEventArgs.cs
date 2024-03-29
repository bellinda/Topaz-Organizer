﻿using System;

namespace TopazOrganizer.OrganizerEvents
{
    public class DataChangedEventArgs : EventArgs
    {
        public OrganizerEvent Data { get; private set; }

        public IEventDataContainer DataSource { get; private set; }

        public DataChangedEventArgs(OrganizerEvent data)
            : this(data, null) {}

        public DataChangedEventArgs(IEventDataContainer dataSource)
            : this(null, dataSource) { }

        public DataChangedEventArgs(OrganizerEvent data, IEventDataContainer dataSource)
        {
            this.Data = data;
            this.DataSource = dataSource;
        }
    }
}
