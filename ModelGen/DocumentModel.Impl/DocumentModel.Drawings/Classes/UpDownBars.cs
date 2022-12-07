namespace DocumentModel.Drawings;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public class UpDownBarsImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.UpDownBars>, UpDownBars
{
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
