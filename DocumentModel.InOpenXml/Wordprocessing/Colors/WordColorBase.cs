namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents base color properties and methods for WordprocessingML documents.
/// </summary>
public abstract partial class WordColorBase<T> : AnyColor<T> where T : DX.OpenXmlElement
{
  /// <summary>
  /// Initializes a new instance of the Color class.
  /// </summary>
  protected WordColorBase() : base()
  {
  }

  /// <summary>
  /// Represents an abstract property to mix a color with white.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Color.ThemeTint))]
  public abstract Percentage? Tint { get; set; }

  /// <summary>
  /// Represents an abstract property to mix a color with black.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Color.ThemeShade))]
  public abstract Percentage? Shade { get; set; }


}