namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the matrix m, including the justification of the matrix and the layout of elements within the matrix.
/// </summary>
[OpenXmlType(typeof(DXM.MatrixProperties))]
public partial class MatrixProperties : ModelElement<DXM.MatrixProperties>
{
 /// <summary>
 ///   Specifies the justification of the matrix. 
 ///   Text outside of the matrix can be aligned with the bottom, top, or center of a matrix object. 
 ///   If this element is omitted, the matrix assumes center justification. 
 ///   In other words, whether the element is absent or present without the val attribute, the default of the val attribute is center.
 /// </summary>
 public VerticalAlignment? BaseJustification { get => _BaseJustification; set => UpdateField(ref _BaseJustification, value, nameof(BaseJustification)); }

 private VerticalAlignment? _BaseJustification;
 /// <summary>
 ///   Hide Placeholders (Matrix).
 /// </summary>
 public bool? HidePlaceholder { get => _HidePlaceholder; set => UpdateField(ref _HidePlaceholder, value, nameof(HidePlaceholder)); }

 private bool? _HidePlaceholder;
 /// <summary>
 ///   Row Spacing.
 /// </summary>
 public RowSpacing? RowSpacing { get => _RowSpacing; set => UpdateField(ref _RowSpacing, value, nameof(RowSpacing)); }

 private RowSpacing? _RowSpacing;
 /// <summary>
 ///   Matrix IColumn Gap Rule.
 /// </summary>
 public Int64? ColumnGapRule { get => _ColumnGapRule; set => UpdateField(ref _ColumnGapRule, value, nameof(ColumnGapRule)); }

 private Int64? _ColumnGapRule;
 /// <summary>
 ///   Matrix IColumn Spacing.
 /// </summary>
 public UInt32? ColumnSpacing { get => _ColumnSpacing; set => UpdateField(ref _ColumnSpacing, value, nameof(ColumnSpacing)); }

 private UInt32? _ColumnSpacing;
 /// <summary>
 ///   Matrix IColumn Gap.
 /// </summary>
 public UInt16? ColumnGap { get => _ColumnGap; set => UpdateField(ref _ColumnGap, value, nameof(ColumnGap)); }

 private UInt16? _ColumnGap;
 /// <summary>
 ///   Matrix IColumns.
 /// </summary>
 public MatrixColumns? MatrixColumns { get => _MatrixColumns; set => UpdateField(ref _MatrixColumns, value, nameof(MatrixColumns)); }

 private MatrixColumns? _MatrixColumns;
 /// <summary>
 ///   Specifies formatting of matrix object argument.
 /// </summary>
 public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

 private ControlProperties? _ControlProperties;
}