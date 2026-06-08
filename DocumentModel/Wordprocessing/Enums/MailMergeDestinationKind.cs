namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MailMergeDestinationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeDestinationKind
{
  /// <summary>
  ///   Send Merged IDocuments Ito New IDocuments.
  /// </summary>
  NewDocument,

  /// <summary>
  ///   Send Merged IDocuments Ito Printer.
  /// </summary>
  Printer,

  /// <summary>
  ///   Send Merged IDocuments as E-mail Messages.
  /// </summary>
  IEmail,

  /// <summary>
  ///   Send Merged IDocuments as Faxes.
  /// </summary>
  Fax
}
