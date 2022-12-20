namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeDestinationType
{
    NewDocument,
    Printer,
    Email,
    Fax,
}