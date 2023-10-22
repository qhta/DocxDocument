namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the ColorStyle Class.
/// </summary>
public partial class ColorStyle
{
  
  /// <summary>
  ///   meth, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Method { get; set; }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Id { get; set; }
  
  public DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
