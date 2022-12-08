namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// seriesName, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? SeriesName
  {
    get;
    set;
  }
  
  /// <summary>
  /// categoryName, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? CategoryName
  {
    get;
    set;
  }
  
  /// <summary>
  /// value, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Value
  {
    get;
    set;
  }
  
}
