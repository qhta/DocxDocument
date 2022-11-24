namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Layout Node.
/// </summary>
public interface ILayoutNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Style Label
  /// </summary>
  public String? StyleLabel { get ; set; }
  
  /// <summary>
  /// Child Order
  /// </summary>
  public ChildOrderValues? ChildOrder { get ; set; }
  
  /// <summary>
  /// Move With
  /// </summary>
  public String? MoveWith { get ; set; }
  
}
