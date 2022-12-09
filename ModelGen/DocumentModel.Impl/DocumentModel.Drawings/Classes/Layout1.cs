namespace DocumentModel.Drawings;

/// <summary>
/// Layout.
/// </summary>
public class Layout1Impl: ModelElementImpl, Layout1
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList3? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
