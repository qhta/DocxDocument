namespace DocumentModel;


/// <summary>
///   Defines the ThemeFamily Class.
/// </summary>
public partial class ThemeFamily
{
  
  /// <summary>
  ///   name, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("name")]
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   vid, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("vid")]
  public String? Vid { get; set; }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
