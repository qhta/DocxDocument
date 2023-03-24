namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Theme.
/// </summary>
public class Theme: ModelElement
{
  /// <summary>
  ///   name
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? ThemeId { get; set; }

  /// <summary>
  ///   ThemeElements.
  /// </summary>
  public ThemeElements? ThemeElements { get; set; }

  /// <summary>
  ///   ObjectDefaults.
  /// </summary>
  public ObjectDefaults? ObjectDefaults { get; set; }

  /// <summary>
  ///   ExtraColorSchemeList.
  /// </summary>
  public ExtraColorSchemeList? ExtraColorSchemeList { get; set; }

  /// <summary>
  ///   CustomColorList.
  /// </summary>
  public CustomColorList? CustomColorList { get; set; }

  /// <summary>
  ///   OfficeStyleSheetExtensionList.
  /// </summary>
  public OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList { get; set; }
}