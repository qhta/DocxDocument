namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Layout Node.
/// </summary>
public interface ILayoutNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Style Label
  /// </summary>
  public System.String? StyleLabel { get ; set; }
  
  /// <summary>
  /// Child Order
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ChildOrderKind? ChildOrder { get ; set; }
  
  /// <summary>
  /// Move With
  /// </summary>
  public System.String? MoveWith { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IAlgorithm? Algorithm { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IPresentationOf? PresentationOf { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IConstraints? Constraints { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IRuleList? RuleList { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IVariableList? VariableList { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IForEach? ForEach { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.ILayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IChoose? Choose { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
