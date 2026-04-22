namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents table style conditional formatting properties for a table row in a Wordprocessing document.
/// This class provides properties for row visibility, splitting, header status, cell spacing, and justification, enabling advanced styling and formatting options for table rows based on conditional formatting rules.
/// </summary>
[XmlRoot("TableStyleConditionalRowProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class TableStyleConditionalRowProperties : ModelElement //<DXW.TableStyleConditionalRowProperties>
{
 /// <summary>
 /// Indicates whether the row is hidden from view in the table.
 /// </summary>
 public bool? Hidden { get => _Hidden; set => UpdateField(ref _Hidden, value, nameof(Hidden)); }
 private bool? _Hidden;

 /// <summary>
 /// Indicates whether the row cannot be split across pages.
 /// </summary>
 public bool? CantSplit { get => _CantSplit; set => UpdateField(ref _CantSplit, value, nameof(CantSplit)); }
 private bool? _CantSplit;

 /// <summary>
 /// Indicates whether the row is styled as a table header row.
 /// </summary>
 public bool? TableHeader { get => _TableHeader; set => UpdateField(ref _TableHeader, value, nameof(TableHeader)); }
 private bool? _TableHeader;

 /// <summary>
 /// Cell spacing for the row, specifying the space between adjacent cells.
 /// </summary>
 public TableMeasure? TableCellSpacing { get => _TableCellSpacing; set => UpdateField(ref _TableCellSpacing, value, nameof(TableCellSpacing)); }
 private TableMeasure? _TableCellSpacing;

 /// <summary>
 /// Table row justification, specifying horizontal alignment of the row within the table.
 /// </summary>
 public TableRowAlignment? TableJustification { get => _TableJustification; set => UpdateField(ref _TableJustification, value, nameof(TableJustification)); }
 private TableRowAlignment? _TableJustification;
}