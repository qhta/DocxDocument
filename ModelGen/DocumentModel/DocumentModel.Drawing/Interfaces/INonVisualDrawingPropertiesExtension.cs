namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public interface INonVisualDrawingPropertiesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ICompatExtension? CompatExtension { get ; set; }
  
  public IBackgroundProperties? BackgroundProperties { get ; set; }
  
  public ICreationId? CreationId { get ; set; }
  
  public IPredecessorDrawingElementReference? PredecessorDrawingElementReference { get ; set; }
  
  public Boolean? Decorative { get ; set; }
  
  public IClassificationOutcome? ClassificationOutcome { get ; set; }
  
  public IScriptLink? ScriptLink { get ; set; }
  
}
