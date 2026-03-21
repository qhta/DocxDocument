namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation. OMath objects are members of the OMaths collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath?view=word-pia"/>
public partial interface OMath : InteropObject
{
  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns the functions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.functions?view=word-pia"/>
  public OMathFunctions Functions { get; }

  /// <summary>
  /// Returns or sets the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.type?view=word-pia"/>
  public WdOMathType Type { get; set; }

  /// <summary>
  /// Returns the parent o math.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentomath?view=word-pia"/>
  public OMath ParentOMath { get; }

  /// <summary>
  /// Returns the parent function.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentfunction?view=word-pia"/>
  public OMathFunction ParentFunction { get; }

  /// <summary>
  /// Returns the parent row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentrow?view=word-pia"/>
  public OMathMatRow ParentRow { get; }

  /// <summary>
  /// Returns the parent col.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentcol?view=word-pia"/>
  public OMathMatCol ParentCol { get; }

  /// <summary>
  /// Returns the parent arg.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentarg?view=word-pia"/>
  public OMath ParentArg { get; }

  /// <summary>
  /// Returns the arg index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.argindex?view=word-pia"/>
  public int ArgIndex { get; }

  /// <summary>
  /// Returns the nesting level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// Returns or sets the arg size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.argsize?view=word-pia"/>
  public int ArgSize { get; set; }

  /// <summary>
  /// Returns the breaks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.breaks?view=word-pia"/>
  public OMathBreaks Breaks { get; }

  /// <summary>
  /// Returns or sets the justification.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.justification?view=word-pia"/>
  public WdOMathJc Justification { get; set; }

  /// <summary>
  /// Returns or sets the align point.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.alignpoint?view=word-pia"/>
  public int AlignPoint { get; set; }
}
