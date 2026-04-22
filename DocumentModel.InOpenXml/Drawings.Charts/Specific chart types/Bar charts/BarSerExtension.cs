namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a bar chart series, providing additional formatting, filtering, and labeling options.
/// </summary>
[OpenXmlType(typeof(DXDC.BarSerExtension))]
[XmlRoot("BarSerExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class BarSerExtension : Extension<DXDC.BarSerExtension>
{
 /// <summary>
 ///   Invert solid fill format for the series.
 /// </summary>
 [OpenXmlElement(typeof(DXO10DC.InvertSolidFillFormat))]
 public InvertSolidFillFormat? InvertSolidFillFormat { get => _InvertSolidFillFormat; set => UpdateField(ref _InvertSolidFillFormat, value, nameof(InvertSolidFillFormat)); }
 private InvertSolidFillFormat? _InvertSolidFillFormat;

 /// <summary>
 ///   Filtered title for the series.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.FilteredSeriesTitle))]
 public FilteredSeriesTitle? FilteredSeriesTitle { get => _FilteredSeriesTitle; set => UpdateField(ref _FilteredSeriesTitle, value, nameof(FilteredSeriesTitle)); }
 private FilteredSeriesTitle? _FilteredSeriesTitle;

 /// <summary>
 ///   Filtered title for the category.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.FilteredCategoryTitle))]
 public FilteredCategoryTitle? FilteredCategoryTitle { get => _FilteredCategoryTitle; set => UpdateField(ref _FilteredCategoryTitle, value, nameof(FilteredCategoryTitle)); }
 private FilteredCategoryTitle? _FilteredCategoryTitle;

 /// <summary>
 ///   Data labels range for the series.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.DataLabelsRange))]
 public DataLabelsRange? DataLabelsRange { get => _DataLabelsRange; set => UpdateField(ref _DataLabelsRange, value, nameof(DataLabelsRange)); }
 private DataLabelsRange? _DataLabelsRange;

 /// <summary>
 ///   Exceptions for category filters applied to the series.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.CategoryFilterExceptions))]
 public CategoryFilterExceptions? CategoryFilterExceptions { get => _CategoryFilterExceptions; set => UpdateField(ref _CategoryFilterExceptions, value, nameof(CategoryFilterExceptions)); }
 private CategoryFilterExceptions? _CategoryFilterExceptions;
}