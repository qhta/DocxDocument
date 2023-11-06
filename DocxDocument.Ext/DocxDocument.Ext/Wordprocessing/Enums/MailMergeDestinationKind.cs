namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MailMergeDestinationValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeDestinationKind
{
  /// <summary>
  ///   Send Merged Documents to New Documents.
  /// </summary>
  NewDocument,

  /// <summary>
  ///   Send Merged Documents to Printer.
  /// </summary>
  Printer,

  /// <summary>
  ///   Send Merged Documents as E-mail Messages.
  /// </summary>
  Email,

  /// <summary>
  ///   Send Merged Documents as Faxes.
  /// </summary>
  Fax
}