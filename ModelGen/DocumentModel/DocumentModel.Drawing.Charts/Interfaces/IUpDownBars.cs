namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public interface IUpDownBars // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gap Width.
  /// </summary>
  public IGapWidth? GapWidth { get ; set; }
  
  /// <summary>
  /// Up Bars.
  /// </summary>
  public IUpBars? UpBars { get ; set; }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  public IDownBars? DownBars { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
