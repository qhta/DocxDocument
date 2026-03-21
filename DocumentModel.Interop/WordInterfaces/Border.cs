namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a border of an object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border?view=word-pia"/>
public interface Border : InteropObject
{
  /// <summary>
  /// The visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.visible?view=word-pia"/>
  public bool Visible { get; set; }
  /// <summary>
  /// The color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.colorindex?view=word-pia"/>
  public WdColorIndex ColorIndex { get; set; }
  /// <summary>
  /// The inside.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.inside?view=word-pia"/>
  public bool Inside { get; }
  /// <summary>
  /// The line style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.linestyle?view=word-pia"/>
  public WdLineStyle LineStyle { get; set; }
  /// <summary>
  /// The line width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.linewidth?view=word-pia"/>
  public WdLineWidth LineWidth { get; set; }
  /// <summary>
  /// The art style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.artstyle?view=word-pia"/>
  public WdPageBorderArt ArtStyle { get; set; }
  /// <summary>
  /// The art width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.artwidth?view=word-pia"/>
  public int ArtWidth { get; set; }
  /// <summary>
  /// The color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.color?view=word-pia"/>
  public WdColor Color { get; set; }

}
