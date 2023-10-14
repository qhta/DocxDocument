namespace DocumentModel;


/// <summary>
///   Defines the BackstageMenuGroup Class.
/// </summary>
public partial class BackstageMenuGroup
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
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Label { get; set; }
  
  
  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetLabel { get; set; }
  
  
  /// <summary>
  ///   itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.ItemSizeKind? ItemSize { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
