namespace DocumentModel.Office2013.Drawing;

/// <summary>
/// Defines the BackgroundProperties Class.
/// </summary>
public interface IBackgroundProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// bwMode, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawing.BlackWhiteMode? Mode { get ; set; }
  
  /// <summary>
  /// bwPure, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawing.BlackWhiteMode? Pure { get ; set; }
  
  /// <summary>
  /// bwNormal, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawing.BlackWhiteMode? Normal { get ; set; }
  
  /// <summary>
  /// targetScreenSize, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Office2013.Drawing.TargetScreenSize? TargetScreenSize { get ; set; }
  
}
