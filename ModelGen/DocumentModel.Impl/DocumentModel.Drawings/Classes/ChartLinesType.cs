namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartLinesType Class.
/// </summary>
public class ChartLinesTypeImpl: ModelElementImpl, ChartLinesType
{
  public DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartLinesTypeImpl(): base() {}
  
  public ChartLinesTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public virtual ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
