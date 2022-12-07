namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PieSerExtension Class.
/// </summary>
public interface PieSerExtension
{
  public FilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public FilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DataLabelsRange? DataLabelsRange { get ; set; }
  
  public CategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
