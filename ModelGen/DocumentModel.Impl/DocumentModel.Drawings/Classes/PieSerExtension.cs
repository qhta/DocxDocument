namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PieSerExtension Class.
/// </summary>
public class PieSerExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>, PieSerExtension
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
