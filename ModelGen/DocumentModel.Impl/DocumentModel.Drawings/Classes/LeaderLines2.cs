namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LeaderLines Class.
/// </summary>
public class LeaderLines2Impl: ModelElementImpl, LeaderLines2
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
