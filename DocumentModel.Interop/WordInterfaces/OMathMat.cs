namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation matrix.
/// </summary>
public partial interface OMathMat : InteropObject
{
  /// <summary>
  /// The rows.
  /// </summary>
  public OMathMatRows Rows { get; }

  /// <summary>
  /// The cols.
  /// </summary>
  public OMathMatCols Cols { get; }

  /// <summary>
  /// The align.
  /// </summary>
  public WdOMathVertAlignType Align { get; set; }

  /// <summary>
  /// The plc hold hidden.
  /// </summary>
  public bool PlcHoldHidden { get; set; }

  /// <summary>
  /// The row spacing rule.
  /// </summary>
  public WdOMathSpacingRule RowSpacingRule { get; set; }

  /// <summary>
  /// The row spacing.
  /// </summary>
  public int RowSpacing { get; set; }

  /// <summary>
  /// The col spacing.
  /// </summary>
  public int ColSpacing { get; set; }

  /// <summary>
  /// The col gap rule.
  /// </summary>
  public WdOMathSpacingRule ColGapRule { get; set; }

  /// <summary>
  /// The col gap.
  /// </summary>
  public int ColGap { get; set; }
}
