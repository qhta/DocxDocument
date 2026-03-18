namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a pie chart series, providing additional filtering and labeling options.
/// </summary>
[OpenXmlType(typeof(DXDC.PieSerExtension))]
public partial class PieSerExtension: Extension<DXDC.PieSerExtension>
{
  /// <summary>
  ///   Filtered title for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FilteredSeriesTitle))]
  public FilteredSeriesTitle? FilteredSeriesTitle
  {
    get => _FilteredSeriesTitle;
    set => UpdateField(ref _FilteredSeriesTitle, value, nameof(FilteredSeriesTitle));
  }

  private FilteredSeriesTitle? _FilteredSeriesTitle;

  /// <summary>
  ///   Filtered title for the category.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FilteredCategoryTitle))]
  public FilteredCategoryTitle? FilteredCategoryTitle
  {
    get => _FilteredCategoryTitle;
    set => UpdateField(ref _FilteredCategoryTitle, value, nameof(FilteredCategoryTitle));
  }

  private FilteredCategoryTitle? _FilteredCategoryTitle;

  /// <summary>
  ///   Data labels range for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.DataLabelsRange))]
  public DataLabelsRange? DataLabelsRange
  {
    get => _DataLabelsRange;
    set => UpdateField(ref _DataLabelsRange, value, nameof(DataLabelsRange));
  }

  private DataLabelsRange? _DataLabelsRange;

  /// <summary>
  ///   Exceptions for category filters applied to the series.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.CategoryFilterExceptions))]
  public CategoryFilterExceptions? CategoryFilterExceptions
  {
    get => _CategoryFilterExceptions;
    set => UpdateField(ref _CategoryFilterExceptions, value, nameof(CategoryFilterExceptions));
  }

  private CategoryFilterExceptions? _CategoryFilterExceptions;
}