namespace DocumentModel;


/// <summary>
///   Defines the LayoutContainer Class.
/// </summary>
public partial class LayoutContainer
{
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? Id { get; set; }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? QualifiedId { get; set; }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag { get; set; }
  
  
  /// <summary>
  ///   align, this property is only available in Office 2010 and later.
  /// </summary>
  public ExpandKind? Align { get; set; }
  
  
  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  public ExpandKind? Expand { get; set; }
  
  
  /// <summary>
  ///   layoutChildren, this property is only available in Office 2010 and later.
  /// </summary>
  public LayoutChildrenKind? LayoutChildren { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
