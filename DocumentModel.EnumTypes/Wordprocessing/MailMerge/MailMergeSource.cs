namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeSourceValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues))]
public enum MailMergeSource
{
  /// <summary>
  ///   Database Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues.Database))]
  Database,
  /// <summary>
  ///   Address Book Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues.AddressBook))]
  AddressBook,
  /// <summary>
  ///   Alternate Document Format Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues.Document1))]
  Document1,
  /// <summary>
  ///   Alternate Document Format Data Source Two.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues.Document2))]
  Document2,
  /// <summary>
  ///   Text File Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues.Text))]
  Text,
  /// <summary>
  ///   E-Mail Program Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues.Email))]
  Email,
  /// <summary>
  ///   Native Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues.Native))]
  Native,
  /// <summary>
  ///   Legacy Document Format Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues.Legacy))]
  Legacy,
  /// <summary>
  ///   Aggregate Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues.Master))]
  Master
}