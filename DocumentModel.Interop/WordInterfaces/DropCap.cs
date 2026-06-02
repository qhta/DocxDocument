namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a dropped capital letter at the beginning of a paragraph.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropcap?view=word-pia"/>
public partial interface IDropCap : IInteropObject
{
  /// <summary>
  /// Gets or sets the position of the drop cap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropcap.position?view=word-pia"/>
  public DropPosition Position { get; set; }

  /// <summary>
  /// Gets or sets the font name for the drop cap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropcap.fontname?view=word-pia"/>
  public string FontName { get; set; }

  /// <summary>
  /// Gets or sets the number of lines that the drop cap occupies.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropcap.linestodrop?view=word-pia"/>
  public int LinesToDrop { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, between the drop cap and the surrounding text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropcap.distancefromtext?view=word-pia"/>
  public float DistanceFromText { get; set; }
}
