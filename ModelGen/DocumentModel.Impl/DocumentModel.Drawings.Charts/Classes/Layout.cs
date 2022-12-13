namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Layout.
/// </summary>
public class LayoutImpl: ModelElementImpl, Layout
{
  public DocumentFormat.OpenXml.Drawing.Charts.Layout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Layout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LayoutImpl(): base() {}
  
  public LayoutImpl(DocumentFormat.OpenXml.Drawing.Charts.Layout openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public DocumentModel.Drawings.Charts.ManualLayout? ManualLayout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
