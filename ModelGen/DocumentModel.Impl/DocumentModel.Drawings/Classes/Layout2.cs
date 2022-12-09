namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Layout Class.
/// </summary>
public class Layout2Impl: ModelElementImpl, Layout2
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
