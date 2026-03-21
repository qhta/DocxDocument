namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation. OMath objects are members of the OMaths collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath?view=word-pia"/>
public partial interface OMath : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The functions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.functions?view=word-pia"/>
  public OMathFunctions Functions { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.type?view=word-pia"/>
  public WdOMathType Type { get; set; }

  /// <summary>
  /// The parent omath.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentomath?view=word-pia"/>
  public OMath ParentOMath { get; }

  /// <summary>
  /// The parent function.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentfunction?view=word-pia"/>
  public OMathFunction ParentFunction { get; }

  /// <summary>
  /// The parent row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentrow?view=word-pia"/>
  public OMathMatRow ParentRow { get; }

  /// <summary>
  /// The parent col.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentcol?view=word-pia"/>
  public OMathMatCol ParentCol { get; }

  /// <summary>
  /// The parent arg.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentarg?view=word-pia"/>
  public OMath ParentArg { get; }

  /// <summary>
  /// The arg index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.argindex?view=word-pia"/>
  public int ArgIndex { get; }

  /// <summary>
  /// The nesting level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// The arg size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.argsize?view=word-pia"/>
  public int ArgSize { get; set; }

  /// <summary>
  /// The breaks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.breaks?view=word-pia"/>
  public OMathBreaks Breaks { get; }

  /// <summary>
  /// The justification.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.justification?view=word-pia"/>
  public WdOMathJc Justification { get; set; }

  /// <summary>
  /// The align point.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.alignpoint?view=word-pia"/>
  public int AlignPoint { get; set; }
}
