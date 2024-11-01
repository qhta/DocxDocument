using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines MailMergeRecipientDataPart.
/// </summary>
public class MailMergeRecipientDataPart: ModelElement
{
  /// <summary>
  ///   Gets or sets the part's root element when the part's content type is
  ///   MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
  /// </summary>
  public Recipients? Recipients { get; set; }

  /// <summary>
  ///   Gets or sets the part's root element when the part's content type is
  ///   MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
  /// </summary>
  public MailMergeRecipients? MailMergeRecipients { get; set; }

  public string? RelationshipType { get; set; }
}