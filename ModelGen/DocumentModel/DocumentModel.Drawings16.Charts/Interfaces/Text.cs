namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Text Class.
/// </summary>
public interface Text
{
  /// <summary>
  /// TextData.
  /// </summary>
  public DocumentModel.Drawings16.Charts.TextData? TextData { get ; set; }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  public DocumentModel.Drawings16.Charts.RichTextBody? RichTextBody { get ; set; }
  
}
