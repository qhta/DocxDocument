namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public interface NonVisualDrawingPropertiesExtension
{
  public CompatExtension? CompatExtension { get ; set; }
  
  public BackgroundProperties? BackgroundProperties { get ; set; }
  
  public CreationId? CreationId { get ; set; }
  
  public PredecessorDrawingElementReference? PredecessorDrawingElementReference { get ; set; }
  
  public ClassificationOutcome? ClassificationOutcome { get ; set; }
  
  public ScriptLink? ScriptLink { get ; set; }
  
}
