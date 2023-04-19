namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BarSerExtension Class.
/// </summary>
public class BarSerExtension: ModelElement
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