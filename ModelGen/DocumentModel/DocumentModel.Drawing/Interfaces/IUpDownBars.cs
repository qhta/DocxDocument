namespace DocumentModel.Drawing;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public interface IUpDownBars // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gap Width.
  /// </summary>
  public System.UInt16? GapWidth { get ; set; }
  
  /// <summary>
  /// Up Bars.
  /// </summary>
  public DocumentModel.Drawing.IUpBars? UpBars { get ; set; }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  public DocumentModel.Drawing.IDownBars? DownBars { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
