namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a change marked with a revision mark.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision?view=word-pia"/>
public partial interface Revision : InteropObject
{
  /// <summary>
  /// Returns the author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.author?view=word-pia"/>
  public string Author { get; }

  /// <summary>
  /// Returns the date.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.date?view=word-pia"/>
  public DateTime Date { get; }

  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.type?view=word-pia"/>
  public WdRevisionType Type { get; }

  /// <summary>
  /// Returns the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns the style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.style?view=word-pia"/>
  public Style Style { get; }

  /// <summary>
  /// Returns the format description.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.formatdescription?view=word-pia"/>
  public string FormatDescription { get; }

  /// <summary>
  /// Returns the moved range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.movedrange?view=word-pia"/>
  public Range MovedRange { get; }

  /// <summary>
  /// Returns the cells.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.cells?view=word-pia"/>
  public Cells Cells { get; }
}
