namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IGapWidth))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IUpBars))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDownBars))]
public interface IUpDownBars // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
