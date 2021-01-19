﻿using System.Collections.Generic;

namespace DDLParser
{
    //TOOD: change the names to match the dbValut names from the template.
    public class HubTableMetadata
    {
        public string TableName;
        public string PolicyHk;
        public string PolicyNumber;
        public string LoadTimestamp;
        public string RecordSource;
        public string PrimaryKey;
        public string SourceModel;
        public List<ColumnDetail> Columns;
        public List<string> ForeignKeys;
    }

    public class ColumnDetail
    {
        public string Name;
        public string DataType;

    }

    public class LinkTableMetadata
    {
        public string TableName;
        public string SrcLdts;
        public string SrcSource;
        public string SrcPk;
        public string SourceModel;
        public List<string> SrcFk;
        public List<ColumnDetail> Columns;
    }

}