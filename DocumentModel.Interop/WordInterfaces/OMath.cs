namespace DocumentModel.Interop;

/// <summary>
/// Represents an equation. OMath objects are members of the OMaths collection.
/// </summary>
public partial interface OMath : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The functions.
  /// </summary>
  public OMathFunctions Functions { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdOMathType Type { get; set; }

  /// <summary>
  /// The parent omath.
  /// </summary>
  public OMath ParentOMath { get; }

  /// <summary>
  /// The parent function.
  /// </summary>
  public OMathFunction ParentFunction { get; }

  /// <summary>
  /// The parent row.
  /// </summary>
  public OMathMatRow ParentRow { get; }

  /// <summary>
  /// The parent col.
  /// </summary>
  public OMathMatCol ParentCol { get; }

  /// <summary>
  /// The parent arg.
  /// </summary>
  public OMath ParentArg { get; }

  /// <summary>
  /// The arg index.
  /// </summary>
  public int ArgIndex { get; }

  /// <summary>
  /// The nesting level.
  /// </summary>
  public int NestingLevel { get; }

  /// <summary>
  /// The arg size.
  /// </summary>
  public int ArgSize { get; set; }

  /// <summary>
  /// The breaks.
  /// </summary>
  public OMathBreaks Breaks { get; }

  /// <summary>
  /// The justification.
  /// </summary>
  public WdOMathJc Justification { get; set; }

  /// <summary>
  /// The align point.
  /// </summary>
  public int AlignPoint { get; set; }
}
