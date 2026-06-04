namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeDestinationValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues))]
public enum MailMergeDestination
{
  /// <summary>
  ///   Send Merged Documents to New Documents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues.NewDocument))]
  NewDocument,
  /// <summary>
  ///   Send Merged Documents to Printer.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues.Printer))]
  Printer,
  /// <summary>
  ///   Send Merged Documents as E-mail Messages.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues.Email))]
  Email,
  /// <summary>
  ///   Send Merged Documents as Faxes.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues.Fax))]
  Fax
}