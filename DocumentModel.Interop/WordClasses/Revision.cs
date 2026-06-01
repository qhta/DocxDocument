namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a change marked with a revision mark.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision?view=word-pia"/>
public partial class Revision : InteropObject
{
  /// <summary>
  /// Returns the name of the user who made the specified tracked change.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.author?view=word-pia"/>
  public string Author { get; }

  /// <summary>
  /// The date and time that the tracked change was made.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.date?view=word-pia"/>
  public DateTime Date { get; }

  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns the revision type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.type?view=word-pia"/>
  public RevisionType Type { get; }

  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns a Style object that represents the style associated with the current author for revisions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.style?view=word-pia"/>
  public Style Style { get; }

  /// <summary>
  /// Returns a String representing a description of tracked formatting changes in a revision.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.formatdescription?view=word-pia"/>
  public string FormatDescription { get; }

  /// <summary>
  /// Returns a Range object that represents a range of text that was moved from one place to another in a document
  /// with tracked changes. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.movedrange?view=word-pia"/>
  public Range MovedRange { get; }

  /// <summary>
  /// Returns a Cells collection that represents the table cells that have been marked with revision marks.
  /// Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.cells?view=word-pia"/>
  public Cells Cells { get; }
}
