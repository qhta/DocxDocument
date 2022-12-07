namespace DocumentModel.Drawings;

/// <summary>
/// Layout Node.
/// </summary>
public interface LayoutNode
{
  /// <summary>
  /// Child Order
  /// </summary>
  public ChildOrderKind? ChildOrder { get ; set; }
  
}
