namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the TextBodyType Class.
/// </summary>
public interface TextBodyType
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
