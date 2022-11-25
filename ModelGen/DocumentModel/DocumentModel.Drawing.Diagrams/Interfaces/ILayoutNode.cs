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
  
}
