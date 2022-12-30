namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Text Body.
/// </summary>
public partial class TextBody
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public DocumentModel.Drawings.ListStyle? ListStyle { get; set; }
  
  public DocumentModel.Drawings.Paragraph? Paragraph { get; set; }
  
}
