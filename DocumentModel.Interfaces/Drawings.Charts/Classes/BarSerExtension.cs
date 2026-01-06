namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BarSerExtension Class.
/// </summary>
public interface BarSerExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public InvertSolidFillFormat? InvertSolidFillFormat { get; set; }
  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }
  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  public DataLabelsRange? DataLabelsRange { get; set; }
  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}