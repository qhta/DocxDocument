namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the columns layout in a section of a Wordprocessing document.
/// This class provides properties for equal column widths, spacing, column count, and separator line, enabling advanced configuration of multi-column layouts within document sections.
/// </summary>
[OpenXmlType(typeof(DXW.Columns))]
public partial class TextColumns : ModelElement<DXW.Columns>, ISectionPropertiesContent
{
 /// <summary>
 /// Indicates whether columns have equal widths.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Columns.EqualWidth))]
 public bool? EqualWidth { get => _EqualWidth; set => UpdateField(ref _EqualWidth, value, nameof(EqualWidth)); }
 private bool? _EqualWidth;
 /// <summary>
 /// Spacing between equal width columns, specified in twips.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Columns.Space))]
 public Twips? Space { get => _Space; set => UpdateField(ref _Space, value, nameof(Space)); }
 private Twips? _Space;
 /// <summary>
 /// Number of equal width columns in the section.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Columns.ColumnCount))]
 public int? ColumnCount { get => _ColumnCount; set => UpdateField(ref _ColumnCount, value, nameof(ColumnCount)); }
 private int? _ColumnCount;
 /// <summary>
 /// Indicates whether a line is drawn between columns.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Columns.Separator))]
 public bool? Separator { get => _Separator; set => UpdateField(ref _Separator, value, nameof(Separator)); }
 private bool? _Separator;
}