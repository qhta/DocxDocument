namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RadarSerExtension Class.
/// </summary>
public class RadarSerExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension>, RadarSerExtension
{
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
