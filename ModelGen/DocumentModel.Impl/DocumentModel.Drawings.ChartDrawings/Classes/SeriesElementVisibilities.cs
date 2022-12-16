namespace DocumentModel.Drawings.ChartDrawings;

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
  
  public SeriesElementVisibilitiesImpl(): base() {}
  
  public SeriesElementVisibilitiesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// connectorLines, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? ConnectorLines
  {
    get => (System.Boolean?)OpenXmlElement?.ConnectorLines?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.MeanLine?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.MeanMarker?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Nonoutliers?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Outliers?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Outliers = (System.Boolean?)value;
    }
  }
  
}
