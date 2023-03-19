namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BarSerExtension Class.
/// </summary>
public class BarSerExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public InvertSolidFillFormat? InvertSolidFillFormat { get; set; }

  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }

  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }

  public DataLabelsRange? DataLabelsRange { get; set; }

  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}