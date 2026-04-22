namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a data table displayed within a chart.
///   A data table shows the underlying data values in a grid format below the chart, providing a clear view of the data used to generate the chart.
///   This class allows configuration of border visibility, legend keys, and visual properties for the data table.
/// </summary>
[OpenXmlType(typeof(DXDC.DataTable))]
[XmlRoot("DataTable", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DataTable : ModelElement<DXDC.DataTable>
{
 /// <summary>
 ///   Indicates whether horizontal borders are shown in the data table.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataTable.ShowHorizontalBorder))]
 public bool? ShowHorizontalBorder { get => _ShowHorizontalBorder; set => UpdateField(ref _ShowHorizontalBorder, value, nameof(ShowHorizontalBorder)); }
 private bool? _ShowHorizontalBorder;

 /// <summary>
 ///   Indicates whether vertical borders are shown in the data table.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataTable.ShowVerticalBorder))]
 public bool? ShowVerticalBorder { get => _ShowVerticalBorder; set => UpdateField(ref _ShowVerticalBorder, value, nameof(ShowVerticalBorder)); }
 private bool? _ShowVerticalBorder;

 /// <summary>
 ///   Indicates whether an outline border is shown around the data table.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataTable.ShowOutlineBorder))]
 public bool? ShowOutlineBorder { get => _ShowOutlineBorder; set => UpdateField(ref _ShowOutlineBorder, value, nameof(ShowOutlineBorder)); }
 private bool? _ShowOutlineBorder;

 /// <summary>
 ///   Indicates whether legend keys are displayed in the data table.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataTable.ShowKeys))]
 public bool? ShowKeys { get => _ShowKeys; set => UpdateField(ref _ShowKeys, value, nameof(ShowKeys)); }
 private bool? _ShowKeys;

 /// <summary>
 ///   Visual and shape properties for the data table.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataTable.ChartShapeProperties))]
 public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }
 private ChartShapeProperties? _ChartShapeProperties;

 /// <summary>
 ///   Text formatting and style properties for the data table.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataTable.TextProperties))]
 public TextProperties? TextProperties { get => _TextProperties; set => UpdateField(ref _TextProperties, value, nameof(TextProperties)); }
 private TextProperties? _TextProperties;

 /// <summary>
 ///   Collection of extension elements for additional data table customization.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DataTable.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}