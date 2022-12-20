namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeDataType
{
    TextFile,
    Database,
    Spreatsheet,
    Query,
    Odbc,
    Native,
}