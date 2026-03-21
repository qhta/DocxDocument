namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation matrix.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat?view=word-pia"/>
public partial interface OMathMat : InteropObject
{
  /// <summary>
  /// The rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.rows?view=word-pia"/>
  public OMathMatRows Rows { get; }

  /// <summary>
  /// The cols.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.cols?view=word-pia"/>
  public OMathMatCols Cols { get; }

  /// <summary>
  /// The align.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.align?view=word-pia"/>
  public WdOMathVertAlignType Align { get; set; }

  /// <summary>
  /// The plc hold hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.plcholdhidden?view=word-pia"/>
  public bool PlcHoldHidden { get; set; }

  /// <summary>
  /// The row spacing rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.rowspacingrule?view=word-pia"/>
  public WdOMathSpacingRule RowSpacingRule { get; set; }

  /// <summary>
  /// The row spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.rowspacing?view=word-pia"/>
  public int RowSpacing { get; set; }

  /// <summary>
  /// The col spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.colspacing?view=word-pia"/>
  public int ColSpacing { get; set; }

  /// <summary>
  /// The col gap rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.colgaprule?view=word-pia"/>
  public WdOMathSpacingRule ColGapRule { get; set; }

  /// <summary>
  /// The col gap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.colgap?view=word-pia"/>
  public int ColGap { get; set; }
}
