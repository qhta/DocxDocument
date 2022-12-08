namespace DocumentModel.Drawings;

/// <summary>
/// Build Chart.
/// </summary>
public class BuildChartImpl: ModelElementImpl, BuildChart
{
  public DocumentFormat.OpenXml.Drawing.BuildChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BuildChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Build
  /// </summary>
  public String? Build
  {
    get;
    set;
  }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public Boolean? AnimateBackground
  {
    get;
    set;
  }
  
}
