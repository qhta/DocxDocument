namespace DocumentModel.Drawings;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public class UpDownBarsImpl: ModelElementImpl, UpDownBars
{
  public DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.UpDownBars?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gap Width.
  /// </summary>
  public UInt16? GapWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Up Bars.
  /// </summary>
  public UpBars? UpBars
  {
    get;
    set;
  }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  public DownBars? DownBars
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
