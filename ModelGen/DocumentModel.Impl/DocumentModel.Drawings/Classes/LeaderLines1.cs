namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LeaderLines Class.
/// </summary>
public class LeaderLines1Impl: ModelElementImpl, LeaderLines1
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
    get;
    set;
  }
  
}
