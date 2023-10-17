namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Layout Node.
/// </summary>
public partial class LayoutNode
{
  
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Style Label
  /// </summary>
  public String? StyleLabel { get; set; }
  
  
  /// <summary>
  ///   Child Order
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ChildOrderKind? ChildOrder { get; set; }
  
  
  /// <summary>
  ///   Move With
  /// </summary>
  public String? MoveWith { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
