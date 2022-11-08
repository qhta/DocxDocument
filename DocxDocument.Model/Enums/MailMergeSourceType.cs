namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeSourceType
{
    Database,
    AddressBook,
    Document1,
    Document2,
    Text,
    Email,
    Native,
    Legacy,
    Master,
}