namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Layout Class.
/// </summary>
public class Layout1Impl: ModelElementImpl, Layout1
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public ManualLayout? ManualLayout
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
