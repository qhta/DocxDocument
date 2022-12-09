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
    get => (String?)OpenXmlElement?.Build?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Build = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public Boolean? AnimateBackground
  {
    get => (Boolean?)OpenXmlElement?.AnimateBackground?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnimateBackground = (System.Boolean?)value;
    }
  }
  
}
