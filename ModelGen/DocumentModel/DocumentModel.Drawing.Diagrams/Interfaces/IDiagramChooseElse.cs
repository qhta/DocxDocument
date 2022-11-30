namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Else.
/// </summary>
public interface IDiagramChooseElse // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IAlgorithm? Algorithm { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IPresentationOf? PresentationOf { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IConstraints? Constraints { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IRuleList? RuleList { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IForEach? ForEach { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.ILayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IChoose? Choose { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
