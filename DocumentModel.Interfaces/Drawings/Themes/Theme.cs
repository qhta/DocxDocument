namespace DocumentModel.Drawings;

/// <summary>
///   Represents a theme, including its name, identifier, theme elements, object defaults, color schemes, custom colors, and extension lists.
/// </summary>
public interface Theme: OfficeStyleSheetExtendableElement
{
  /// <summary>
  ///   Name of the theme.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Identifier for the theme.
  /// </summary>
  public string? ThemeId { get; set; }

  /// <summary>
  ///   Elements that define the theme's appearance.
  /// </summary>
  public ThemeElements? ThemeElements { get; set; }

  /// <summary>
  ///   Default formatting for objects in the theme.
  /// </summary>
  public ObjectDefaults? ObjectDefaults { get; set; }

  /// <summary>
  ///   List of extra color schemes associated with the theme.
  /// </summary>
  public ExtraColorSchemeList? ExtraColorSchemeList { get; set; }

  /// <summary>
  ///   List of custom colors defined for the theme.
  /// </summary>
  public CustomColorList? CustomColorList { get; set; }
}