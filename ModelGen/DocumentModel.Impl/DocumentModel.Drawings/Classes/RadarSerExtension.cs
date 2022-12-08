namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RadarSerExtension Class.
/// </summary>
public class RadarSerExtensionImpl: ModelElementImpl, RadarSerExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public FilteredSeriesTitle? FilteredSeriesTitle
  {
    get;
    set;
  }
  
  public FilteredCategoryTitle? FilteredCategoryTitle
  {
    get;
    set;
  }
  
  public DataLabelsRange? DataLabelsRange
  {
    get;
    set;
  }
  
  public CategoryFilterExceptions? CategoryFilterExceptions
  {
    get;
    set;
  }
  
}
