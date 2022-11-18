namespace DocumentModel.Wordprocessing;

/// <summary>
/// Merged Document To E-Mail Attachment.
/// </summary>
public interface IMailAsAttachment // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
