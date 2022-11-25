namespace DocumentModel.Drawing.Charts;

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
  public DocumentModel.Drawing.Charts.IUpDownBarType? UpBars { get ; set; }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  public DocumentModel.Drawing.Charts.IUpDownBarType? DownBars { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
