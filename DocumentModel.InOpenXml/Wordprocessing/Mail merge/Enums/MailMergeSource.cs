namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeSourceValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.MailMergeSourceValues))]
public enum MailMergeSource
{
  /// <summary>
  ///   Database Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeSourceValues.Database))]
  Database,
  /// <summary>
  ///   Address Book Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeSourceValues.AddressBook))]
  AddressBook,
  /// <summary>
  ///   Alternate Document Format Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeSourceValues.Document1))]
  Document1,
  /// <summary>
  ///   Alternate Document Format Data Source Two.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeSourceValues.Document2))]
  Document2,
  /// <summary>
  ///   Text File Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeSourceValues.Text))]
  Text,
  /// <summary>
  ///   E-Mail Program Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeSourceValues.Email))]
  Email,
  /// <summary>
  ///   Native Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeSourceValues.Native))]
  Native,
  /// <summary>
  ///   Legacy Document Format Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeSourceValues.Legacy))]
  Legacy,
  /// <summary>
  ///   Aggregate Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeSourceValues.Master))]
  Master
}