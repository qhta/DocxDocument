namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LeaderLines Class.
/// </summary>
public class LeaderLinesImpl: ModelElementImpl, LeaderLines
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LeaderLinesImpl(): base() {}
  
  public LeaderLinesImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
