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
  
  public DocumentModel.Office2010.Drawing.ICompatExtension? CompatExtension { get ; set; }
  
  public DocumentModel.Office2013.Drawing.IBackgroundProperties? BackgroundProperties { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ICreationId? CreationId { get ; set; }
  
  public DocumentModel.Office2016.Drawing.IPredecessorDrawingElementReference? PredecessorDrawingElementReference { get ; set; }
  
  public System.Boolean? Decorative { get ; set; }
  
  public DocumentModel.Office2021.Drawing.DocumentClassification.IClassificationOutcome? ClassificationOutcome { get ; set; }
  
  public DocumentModel.Office.Drawing.Y2021.ScriptLink.IScriptLink? ScriptLink { get ; set; }
  
}
