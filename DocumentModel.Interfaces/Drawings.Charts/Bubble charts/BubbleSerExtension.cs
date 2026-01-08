namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a bubble chart series, providing additional formatting, filtering, and labeling options.
/// </summary>
public interface BubbleSerExtension : Extension
{
  /// <summary>
  ///   Invert solid fill format for the series.
  /// </summary>
  public InvertSolidFillFormat? InvertSolidFillFormat { get; set; }

  /// <summary>
  ///   Filtered title for the category.
  /// </summary>
  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }

  /// <summary>
  ///   Data labels range for the series.
  /// </summary>
  public DataLabelsRange? DataLabelsRange { get; set; }

  /// <summary>
  ///   Exceptions for category filters applied to the series.
  /// </summary>
  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}