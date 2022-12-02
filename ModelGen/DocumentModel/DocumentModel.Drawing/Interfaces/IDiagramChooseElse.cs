namespace DocumentModel.Drawing;

/// <summary>
/// Else.
/// </summary>
public interface IDiagramChooseElse // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  public DocumentModel.Drawing.IAlgorithm? Algorithm { get ; set; }
  
  public DocumentModel.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.IPresentationOf? PresentationOf { get ; set; }
  
  public DocumentModel.Drawing.IConstraints? Constraints { get ; set; }
  
  public DocumentModel.Drawing.IRuleList? RuleList { get ; set; }
  
  public DocumentModel.Drawing.IForEach? ForEach { get ; set; }
  
  public DocumentModel.Drawing.ILayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawing.IChoose? Choose { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
