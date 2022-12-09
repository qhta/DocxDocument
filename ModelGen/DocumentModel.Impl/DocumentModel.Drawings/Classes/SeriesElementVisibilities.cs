namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SeriesElementVisibilities Class.
/// </summary>
public class SeriesElementVisibilitiesImpl: ModelElementImpl, SeriesElementVisibilities
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// connectorLines, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? ConnectorLines
  {
    get => (Boolean?)OpenXmlElement?.ConnectorLines?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectorLines = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// meanLine, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? MeanLine
  {
    get => (Boolean?)OpenXmlElement?.MeanLine?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MeanLine = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// meanMarker, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? MeanMarker
  {
    get => (Boolean?)OpenXmlElement?.MeanMarker?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MeanMarker = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// nonoutliers, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Nonoutliers
  {
    get => (Boolean?)OpenXmlElement?.Nonoutliers?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Nonoutliers = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// outliers, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Outliers
  {
    get => (Boolean?)OpenXmlElement?.Outliers?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Outliers = (System.Boolean?)value;
    }
  }
  
}
