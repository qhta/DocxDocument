namespace DocumentModel.Wordprocessing;

/// <summary>
/// Merged Document To E-Mail Attachment.
/// </summary>
public class MailAsAttachment: IMailAsAttachment
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
