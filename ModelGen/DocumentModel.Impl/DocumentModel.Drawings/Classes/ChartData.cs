namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public class ChartDataImpl: ModelElementImpl, ChartData
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ExternalData.
  /// </summary>
  public ExternalData1? ExternalData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Data2>? Datas
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList2? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
