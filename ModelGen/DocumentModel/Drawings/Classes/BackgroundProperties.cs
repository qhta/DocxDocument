namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundProperties Class.
/// </summary>
public partial class BackgroundProperties
{
  
  /// <summary>
  ///   bwMode, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("bwMode")]
  public DocumentModel.Drawings.BlackWhiteModeValues? Mode { get; set; }
  
  
  /// <summary>
  ///   bwPure, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("bwPure")]
  public DocumentModel.Drawings.BlackWhiteModeValues? Pure { get; set; }
  
  
  /// <summary>
  ///   bwNormal, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("bwNormal")]
  public DocumentModel.Drawings.BlackWhiteModeValues? Normal { get; set; }
  
  
  /// <summary>
  ///   targetScreenSize, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("targetScreenSize")]
  public DocumentModel.Drawings.TargetScreenSize? TargetScreenSize { get; set; }
  
}
