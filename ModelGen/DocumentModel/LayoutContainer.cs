namespace DocumentModel;


/// <summary>
///   Defines the LayoutContainer Class.
/// </summary>
public partial class LayoutContainer
{
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId { get; set; }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag { get; set; }
  
  
  /// <summary>
  ///   align, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.ExpandKind? Align { get; set; }
  
  
  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.ExpandKind? Expand { get; set; }
  
  
  /// <summary>
  ///   layoutChildren, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.LayoutChildrenKind? LayoutChildren { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
