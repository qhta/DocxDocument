namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public interface NonVisualDrawingPropertiesExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings.CompatExtension? CompatExtension { get ; set; }
  
  public DocumentModel.Drawings.BackgroundProperties? BackgroundProperties { get ; set; }
  
  public DocumentModel.Drawings.CreationId? CreationId { get ; set; }
  
  public DocumentModel.Drawings.PredecessorDrawingElementReference? PredecessorDrawingElementReference { get ; set; }
  
  public Boolean? Decorative { get ; set; }
  
  public DocumentModel.Drawings.ClassificationOutcome? ClassificationOutcome { get ; set; }
  
  public DocumentModel.Drawings.Office.ScriptLink.ScriptLink? ScriptLink { get ; set; }
  
}
