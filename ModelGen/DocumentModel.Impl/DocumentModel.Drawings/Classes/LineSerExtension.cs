namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSerExtension Class.
/// </summary>
public class LineSerExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>, LineSerExtension
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
