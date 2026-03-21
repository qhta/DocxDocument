namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single list level, either the only level for a bulleted or numbered list or one of the nine levels of an outline numbered list.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel?view=word-pia"/>
public partial interface ListLevel : InteropObject
{
  /// <summary>
  /// Returns the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns or sets the number format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.numberformat?view=word-pia"/>
  public string NumberFormat { get; set; }

  /// <summary>
  /// Returns or sets the trailing character.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.trailingcharacter?view=word-pia"/>
  public WdTrailingCharacter TrailingCharacter { get; set; }

  /// <summary>
  /// Returns or sets the number style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.numberstyle?view=word-pia"/>
  public WdListNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// Returns or sets the number position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.numberposition?view=word-pia"/>
  public float NumberPosition { get; set; }

  /// <summary>
  /// Returns or sets the alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.alignment?view=word-pia"/>
  public WdListLevelAlignment Alignment { get; set; }

  /// <summary>
  /// Returns or sets the text position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.textposition?view=word-pia"/>
  public float TextPosition { get; set; }

  /// <summary>
  /// Returns or sets the tab position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.tabposition?view=word-pia"/>
  public float TabPosition { get; set; }

  /// <summary>
  /// Returns or sets whether reset on higher old.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.resetonhigherold?view=word-pia"/>
  public bool ResetOnHigherOld { get; set; }

  /// <summary>
  /// Returns or sets the start at.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.startat?view=word-pia"/>
  public int StartAt { get; set; }

  /// <summary>
  /// Returns or sets the linked style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.linkedstyle?view=word-pia"/>
  public string LinkedStyle { get; set; }

  /// <summary>
  /// Returns or sets the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// Returns or sets the reset on higher.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.resetonhigher?view=word-pia"/>
  public int ResetOnHigher { get; set; }

  /// <summary>
  /// Returns the picture bullet.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.picturebullet?view=word-pia"/>
  public InlineShape PictureBullet { get; }
}
