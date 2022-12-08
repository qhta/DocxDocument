namespace DocumentModel.Drawings;

/// <summary>
/// Layout.
/// </summary>
public class Layout2Impl: ModelElementImpl, Layout2
{
  public DocumentFormat.OpenXml.Drawing.Charts.Layout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Layout?)_OpenXmlElement;
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
