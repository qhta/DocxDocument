using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines MailMergeRecipientDataPart.
/// </summary>
public class MailMergeRecipientDataPart
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

  public String? RelationshipType { get; set; }
}