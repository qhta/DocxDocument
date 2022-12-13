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
  
  public DocumentModel.Drawings13.BackgroundProperties? BackgroundProperties { get ; set; }
  
  public DocumentModel.Drawings16.CreationId? CreationId { get ; set; }
  
  public DocumentModel.Drawings16.PredecessorDrawingElementReference? PredecessorDrawingElementReference { get ; set; }
  
  public Boolean? Decorative { get ; set; }
  
  public DocumentModel.Drawings.ClassificationOutcome? ClassificationOutcome { get ; set; }
  
  public DocumentModel.Drawings.ScriptLink? ScriptLink { get ; set; }
  
}
