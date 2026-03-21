namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a change marked with a revision mark.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision?view=word-pia"/>
public partial interface Revision : InteropObject
{
  /// <summary>
  /// The author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.author?view=word-pia"/>
  public string Author { get; }

  /// <summary>
  /// The date.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.date?view=word-pia"/>
  public DateTime Date { get; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.type?view=word-pia"/>
  public WdRevisionType Type { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.style?view=word-pia"/>
  public Style Style { get; }

  /// <summary>
  /// The format description.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.formatdescription?view=word-pia"/>
  public string FormatDescription { get; }

  /// <summary>
  /// The moved range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.movedrange?view=word-pia"/>
  public Range MovedRange { get; }

  /// <summary>
  /// The cells.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.cells?view=word-pia"/>
  public Cells Cells { get; }
}
