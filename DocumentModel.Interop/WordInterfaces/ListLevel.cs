namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single list level, either the only level for a bulleted or numbered list or one of the nine levels of an outline numbered list.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel?view=word-pia"/>
public partial interface ListLevel : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The number format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.numberformat?view=word-pia"/>
  public string NumberFormat { get; set; }

  /// <summary>
  /// The trailing character.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.trailingcharacter?view=word-pia"/>
  public WdTrailingCharacter TrailingCharacter { get; set; }

  /// <summary>
  /// The number style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.numberstyle?view=word-pia"/>
  public WdListNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// The number position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.numberposition?view=word-pia"/>
  public float NumberPosition { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.alignment?view=word-pia"/>
  public WdListLevelAlignment Alignment { get; set; }

  /// <summary>
  /// The text position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.textposition?view=word-pia"/>
  public float TextPosition { get; set; }

  /// <summary>
  /// The tab position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.tabposition?view=word-pia"/>
  public float TabPosition { get; set; }

  /// <summary>
  /// The reset on higher old.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.resetonhigherold?view=word-pia"/>
  public bool ResetOnHigherOld { get; set; }

  /// <summary>
  /// The start at.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.startat?view=word-pia"/>
  public int StartAt { get; set; }

  /// <summary>
  /// The linked style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.linkedstyle?view=word-pia"/>
  public string LinkedStyle { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// The reset on higher.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.resetonhigher?view=word-pia"/>
  public int ResetOnHigher { get; set; }

  /// <summary>
  /// The picture bullet.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.picturebullet?view=word-pia"/>
  public InlineShape PictureBullet { get; }
}
