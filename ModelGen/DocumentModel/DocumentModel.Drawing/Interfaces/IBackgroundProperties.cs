namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BackgroundProperties Class.
/// </summary>
public interface IBackgroundProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// bwMode, this property is only available in Office 2013 and later.
  /// </summary>
  public BlackWhiteMode? Mode { get ; set; }
  
  /// <summary>
  /// bwPure, this property is only available in Office 2013 and later.
  /// </summary>
  public BlackWhiteMode? Pure { get ; set; }
  
  /// <summary>
  /// bwNormal, this property is only available in Office 2013 and later.
  /// </summary>
  public BlackWhiteMode? Normal { get ; set; }
  
  /// <summary>
  /// targetScreenSize, this property is only available in Office 2013 and later.
  /// </summary>
  public TargetScreenSize? TargetScreenSize { get ; set; }
  
}
