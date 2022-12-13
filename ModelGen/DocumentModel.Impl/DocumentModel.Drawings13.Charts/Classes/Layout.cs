namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the Layout Class.
/// </summary>
public class LayoutImpl: ModelElementImpl, Layout
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LayoutImpl(): base() {}
  
  public LayoutImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout openXmlElement): base(openXmlElement)
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
