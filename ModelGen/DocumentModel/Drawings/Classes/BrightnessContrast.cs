namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BrightnessContrast Class.
/// </summary>
public partial class BrightnessContrast
{
  
  /// <summary>
  ///   bright, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("bright")]
  public Int32? Bright { get; set; }
  
  
  /// <summary>
  ///   contrast, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("contrast")]
  public Int32? Contrast { get; set; }
  
}
