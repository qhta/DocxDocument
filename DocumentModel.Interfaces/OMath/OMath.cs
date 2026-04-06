namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an equation. OMath objects are members of the OMaths collection.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath?view=word-pia"/>
public partial interface IOMath : IModelObject
{
  /// <summary>
  /// Returns the range that contains the equation.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.range?view=word-pia"/>
  public IRange Range { get; }

  /// <summary>
  /// Returns the collection of equation functions.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.functions?view=word-pia"/>
  public IOMathFunctions Functions { get; }

  /// <summary>
  /// Returns or sets the type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.type?view=word-pia"/>
  public OMathType Type { get; set; }

  /// <summary>
  /// Returns the parent equation.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentomath?view=word-pia"/>
  public IOMath ParentOMath { get; }

  /// <summary>
  /// Returns the parent equation function.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentfunction?view=word-pia"/>
  public IOMathFunction ParentFunction { get; }

  /// <summary>
  /// Returns the parent matrix row.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentrow?view=word-pia"/>
  public IOMathMatRow ParentRow { get; }

  /// <summary>
  /// Returns the parent matrix column.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentcol?view=word-pia"/>
  public IOMathMatCol ParentCol { get; }

  /// <summary>
  /// Returns the parent argument equation.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.parentarg?view=word-pia"/>
  public IOMath ParentArg { get; }

  /// <summary>
  /// Returns the index of the argument within the parent function.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.argindex?view=word-pia"/>
  public int ArgIndex { get; }

  /// <summary>
  /// Returns the nesting level.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// Returns or sets the argument size.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.argsize?view=word-pia"/>
  public int ArgSize { get; set; }

  /// <summary>
  /// Returns the collection of equation line breaks.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.breaks?view=word-pia"/>
  public IOMathBreaks Breaks { get; }

  /// <summary>
  /// Returns or sets the justification.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.justification?view=word-pia"/>
  public OMathJc Justification { get; set; }

  /// <summary>
  /// Returns or sets the alignment point for the equation.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omath.alignpoint?view=word-pia"/>
  public int AlignPoint { get; set; }
}
