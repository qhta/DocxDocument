namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeDestinationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.MailMergeDestinationValues))]
public enum MailMergeDestinationKind
{
  /// <summary>
  ///   Send Merged Documents to New Documents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDestinationValues.NewDocument))]
  NewDocument,
  /// <summary>
  ///   Send Merged Documents to Printer.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDestinationValues.Printer))]
  Printer,
  /// <summary>
  ///   Send Merged Documents as E-mail Messages.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDestinationValues.Email))]
  Email,
  /// <summary>
  ///   Send Merged Documents as Faxes.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDestinationValues.Fax))]
  Fax
}