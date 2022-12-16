namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Shape Text Body.
/// </summary>
public interface TextBody
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public DocumentModel.Drawings.ListStyle? ListStyle { get ; set; }
  
  public DocumentModel.Drawings.Paragraph? Paragraph { get ; set; }
  
}
