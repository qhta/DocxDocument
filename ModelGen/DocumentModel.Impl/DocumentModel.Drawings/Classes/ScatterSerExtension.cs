namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScatterSerExtension Class.
/// </summary>
public class ScatterSerExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension>, ScatterSerExtension
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
