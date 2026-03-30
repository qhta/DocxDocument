using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single list level, either the only level for a bulleted or numbered list or one of the nine levels of an outline numbered list.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel?view=word-pia"/>
public partial interface ListLevel : IModelObject
{
  /// <summary>
  /// Returns the index number of the list level in the list levels collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns or sets the number format for the list level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.numberformat?view=word-pia"/>
  public string NumberFormat { get; set; }

  /// <summary>
  /// Returns or sets the character inserted after the list number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.trailingcharacter?view=word-pia"/>
  public TrailingCharacter TrailingCharacter { get; set; }

  /// <summary>
  /// Returns or sets the numbering style for the list level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.numberstyle?view=word-pia"/>
  public NumberStyle NumberStyle { get; set; }

  /// <summary>
  /// Returns or sets the position of the list number, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.numberposition?view=word-pia"/>
  public float NumberPosition { get; set; }

  /// <summary>
  /// Returns or sets the alignment of the list number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.alignment?view=word-pia"/>
  public ListLevelAlignment Alignment { get; set; }

  /// <summary>
  /// Returns or sets the position of the list text, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.textposition?view=word-pia"/>
  public float TextPosition { get; set; }

  /// <summary>
  /// Returns or sets the tab position for the list level, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.tabposition?view=word-pia"/>
  public float TabPosition { get; set; }

  /// <summary>
  /// Returns or sets whether numbering restarts when a higher list level is used.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.resetonhigherold?view=word-pia"/>
  public bool ResetOnHigherOld { get; set; }

  /// <summary>
  /// Returns or sets the starting number for the list level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.startat?view=word-pia"/>
  public int StartAt { get; set; }

  /// <summary>
  /// Returns or sets the paragraph style linked to the list level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.linkedstyle?view=word-pia"/>
  public string LinkedStyle { get; set; }

  /// <summary>
  /// Returns or sets the font formatting for the list number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.font?view=word-pia"/>
  public IFont Font { get; set; }

  /// <summary>
  /// Returns or sets the higher list level that causes numbering to restart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.resetonhigher?view=word-pia"/>
  public int ResetOnHigher { get; set; }

  /// <summary>
  /// Returns the picture bullet for the list level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.picturebullet?view=word-pia"/>
  public Drw.InlineShape PictureBullet { get; }
}
