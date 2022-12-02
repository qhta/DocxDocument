namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public interface INonVisualDrawingPropertiesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.ICompatExtension? CompatExtension { get ; set; }
  
  public DocumentModel.Drawing.IBackgroundProperties? BackgroundProperties { get ; set; }
  
  public DocumentModel.Drawing.ICreationId? CreationId { get ; set; }
  
  public DocumentModel.Drawing.IPredecessorDrawingElementReference? PredecessorDrawingElementReference { get ; set; }
  
  public System.Boolean? Decorative { get ; set; }
  
  public DocumentModel.Drawing.IClassificationOutcome? ClassificationOutcome { get ; set; }
  
  public DocumentModel.Drawing.IScriptLink? ScriptLink { get ; set; }
  
}
