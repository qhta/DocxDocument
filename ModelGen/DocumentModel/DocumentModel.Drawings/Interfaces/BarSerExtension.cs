namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BarSerExtension Class.
/// </summary>
public interface BarSerExtension
{
  public InvertSolidFillFormat? InvertSolidFillFormat { get ; set; }
  
  public FilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public FilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DataLabelsRange? DataLabelsRange { get ; set; }
  
  public CategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
