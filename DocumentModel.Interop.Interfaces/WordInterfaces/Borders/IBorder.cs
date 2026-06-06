namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a border of an object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border?view=word-pia"/>
public interface IBorder : IInteropObject
{
  /// <summary>
  /// Gets or sets a value indicating whether the border is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.visible?view=word-pia"/>
  public bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the color index for the border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.colorindex?view=word-pia"/>
  public ColorIndex ColorIndex { get; set; }
  /// <summary>
  /// Gets a value indicating whether the border is an inside border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.inside?view=word-pia"/>
  public bool Inside { get; }
  /// <summary>
  /// Gets or sets the line style for the border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.linestyle?view=word-pia"/>
  public LineStyle LineStyle { get; set; }
  /// <summary>
  /// Gets or sets the line width for the border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.linewidth?view=word-pia"/>
  public LineWidth LineWidth { get; set; }
  /// <summary>
  /// Gets or sets the page border art style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.artstyle?view=word-pia"/>
  public PageBorderArt ArtStyle { get; set; }
  /// <summary>
  /// Gets or sets the width of the page border art.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.artwidth?view=word-pia"/>
  public int ArtWidth { get; set; }
  /// <summary>
  /// Gets or sets the border color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.color?view=word-pia"/>
  public PresetColors Color { get; set; }

}
