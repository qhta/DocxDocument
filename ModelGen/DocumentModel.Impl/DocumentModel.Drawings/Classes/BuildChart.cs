namespace DocumentModel.Drawings;

/// <summary>
/// Build Chart.
/// </summary>
public partial class BuildChartImpl: ModelElementImpl, BuildChart
{
  public DocumentFormat.OpenXml.Drawing.BuildChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BuildChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BuildChartImpl(): base() {}
  
  public BuildChartImpl(DocumentFormat.OpenXml.Drawing.BuildChart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Build
  /// </summary>
  public String? Build
  {
    get => (System.String?)OpenXmlElement?.Build?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.AnimateBackground?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnimateBackground = (System.Boolean?)value;
    }
  }
  
}
