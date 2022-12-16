namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabelVisibilities Class.
/// </summary>
public class DataLabelVisibilitiesImpl: ModelElementImpl, DataLabelVisibilities
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataLabelVisibilitiesImpl(): base() {}
  
  public DataLabelVisibilitiesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// seriesName, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? SeriesName
  {
    get => (System.Boolean?)OpenXmlElement?.SeriesName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SeriesName = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// categoryName, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? CategoryName
  {
    get => (System.Boolean?)OpenXmlElement?.CategoryName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CategoryName = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// value, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Value
  {
    get => (System.Boolean?)OpenXmlElement?.Value?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Value = (System.Boolean?)value;
    }
  }
  
}
