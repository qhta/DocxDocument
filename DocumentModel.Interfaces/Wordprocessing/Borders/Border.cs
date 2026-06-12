using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a border of an object.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border?view=word-pia"/>
public interface IBorder : IModelObject
{
  /// <summary>
  /// Gets or sets a value indicating whether the border is visible.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.visible?view=word-pia"/>
  public bool Visible { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the color index for the border.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.colorindex?view=word-pia"/>
  public ColorIndex ColorIndex { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets a value indicating whether the border is an inside border.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.inside?view=word-pia"/>
  public bool Inside { get; }
  /// <summary>
  /// Gets or sets the line style for the border.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.linestyle?view=word-pia"/>
  public LineStyle LineStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the line width for the border.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.linewidth?view=word-pia"/>
  public LineWidth LineWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the page border art style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.artstyle?view=word-pia"/>
  public PageBorderArt ArtStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the width of the page border art.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.artwidth?view=word-pia"/>
  public int ArtWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the border color.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.border.color?view=word-pia"/>
  public IColor Color { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}
