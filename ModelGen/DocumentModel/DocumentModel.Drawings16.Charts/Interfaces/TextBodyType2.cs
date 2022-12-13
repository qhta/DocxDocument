namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the TextBodyType Class.
/// </summary>
public interface TextBodyType2
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public DocumentModel.Drawings.ListStyle? ListStyle { get ; set; }
  
}
