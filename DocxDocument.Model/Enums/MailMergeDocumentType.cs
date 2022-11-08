namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeDocumentType
{
    Catalog,
    Envelope,
    MailingLabel,
    FormLetter,
    Email,
    Fax
}