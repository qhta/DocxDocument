namespace DocumentModel;


/// <summary>
///   Defines the Backstage Class.
/// </summary>
public partial class Backstage
{
  
  /// <summary>
  ///   onShow, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("onShow")]
  public String? OnShow { get; set; }
  
  
  /// <summary>
  ///   onHide, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("onHide")]
  public String? OnHide { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
