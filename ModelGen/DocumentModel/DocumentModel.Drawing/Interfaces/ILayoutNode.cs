namespace DocumentModel.Drawing;

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
  public DocumentModel.Drawing.ChildOrderKind? ChildOrder { get ; set; }
  
  /// <summary>
  /// Move With
  /// </summary>
  public System.String? MoveWith { get ; set; }
  
  public DocumentModel.Drawing.IAlgorithm? Algorithm { get ; set; }
  
  public DocumentModel.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.IPresentationOf? PresentationOf { get ; set; }
  
  public DocumentModel.Drawing.IConstraints? Constraints { get ; set; }
  
  public DocumentModel.Drawing.IRuleList? RuleList { get ; set; }
  
  public DocumentModel.Drawing.IVariableList? VariableList { get ; set; }
  
  public DocumentModel.Drawing.IForEach? ForEach { get ; set; }
  
  public DocumentModel.Drawing.ILayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawing.IChoose? Choose { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
