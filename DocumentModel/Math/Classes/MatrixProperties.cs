namespace DocumentModel.Math;

/// <summary>
///   This element specifies properties of the matrix m, including the justification of the matrix and the layout of elements within the matrix.
/// </summary>
public class MatrixProperties: ModelElement
{
  /// <summary>
  ///   Specifies the justification of the matrix. 
  ///   Text outside of the matrix can be aligned with the bottom, top, or center of a matrix object. 
  ///   If this element is omitted, the matrix assumes center justification. 
  ///   In other words, whether the element is absent or present without the val attribute, the default of the val attribute is center.
  /// </summary>
  public VerticalAlignmentKind? BaseJustification { get; set; }

  /// <summary>
  ///   Hide Placeholders (Matrix).
  /// </summary>
  public bool? HidePlaceholder { get; set; }

  /// <summary>
  ///   Row Spacing.
  /// </summary>
  public RowSpacing? RowSpacing { get; set; }

  /// <summary>
  ///   Matrix Column Gap Rule.
  /// </summary>
  public Int64? ColumnGapRule { get; set; }

  /// <summary>
  ///   Matrix Column Spacing.
  /// </summary>
  public UInt32? ColumnSpacing { get; set; }

  /// <summary>
  ///   Matrix Column Gap.
  /// </summary>
  public UInt16? ColumnGap { get; set; }

  /// <summary>
  ///   Matrix Columns.
  /// </summary>
  public MatrixColumns? MatrixColumns { get; set; }

  /// <summary>
  ///   Specifies formatting of matrix object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}