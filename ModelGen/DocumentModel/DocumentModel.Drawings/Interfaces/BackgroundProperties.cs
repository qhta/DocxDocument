namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundProperties Class.
/// </summary>
public partial interface BackgroundProperties
{
  /// <summary>
  /// bwMode, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? Mode { get; set; }
  
  /// <summary>
  /// bwPure, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? Pure { get; set; }
  
  /// <summary>
  /// bwNormal, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? Normal { get; set; }
  
  /// <summary>
  /// targetScreenSize, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.TargetScreenSize? TargetScreenSize { get; set; }
  
}
