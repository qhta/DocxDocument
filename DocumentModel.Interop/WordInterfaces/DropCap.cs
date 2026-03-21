namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a dropped capital letter at the beginning of a paragraph.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropcap?view=word-pia"/>
public partial interface DropCap : InteropObject
{
  /// <summary>
  /// The position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropcap.position?view=word-pia"/>
  public WdDropPosition Position { get; set; }

  /// <summary>
  /// The font name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropcap.fontname?view=word-pia"/>
  public string FontName { get; set; }

  /// <summary>
  /// The lines to drop.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropcap.linestodrop?view=word-pia"/>
  public int LinesToDrop { get; set; }

  /// <summary>
  /// The distance from text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropcap.distancefromtext?view=word-pia"/>
  public float DistanceFromText { get; set; }
}
