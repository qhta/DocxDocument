namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ColorScheme Class.
/// </summary>
public partial class ColorScheme
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }

  public ThemeColors ThemeColors { get; set; } = new ThemeColors();

  #region specific color definitions
  /// <summary>
  ///   Dark 1.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Dark1Color
  {
    get => ThemeColors["Dark1Color"];
    set => ThemeColors["Dark1Color"] = value;
  }

  /// <summary>
  ///   Light 1.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Light1Color 
  {
    get => ThemeColors["Light1Color"];
    set => ThemeColors["Light1Color"] = value;
  }

  /// <summary>
  ///   Dark 2.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Dark2Color 
  {
    get => ThemeColors["Dark2Color"];
    set => ThemeColors["Dark2Color"] = value;
  }

  /// <summary>
  ///   Light 2.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Light2Color 
  {
    get => ThemeColors["Light2Color"];
    set => ThemeColors["Light2Color"] = value;
  }

  /// <summary>
  ///   Accent 1.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent1Color 
  {
    get => ThemeColors["Accent1Color"];
    set => ThemeColors["Accent1Color"] = value;
  }

  /// <summary>
  ///   Accent 2.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent2Color 
  {
    get => ThemeColors["Accent2Color"];
    set => ThemeColors["Accent2Color"] = value;
  }

  /// <summary>
  ///   Accent 3.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent3Color 
  {
    get => ThemeColors["Accent3Color"];
    set => ThemeColors["Accent3Color"] = value;
  }

  /// <summary>
  ///   Accent 4.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent4Color 
  {
    get => ThemeColors["Accent4Color"];
    set => ThemeColors["Accent4Color"] = value;
  }

  /// <summary>
  ///   Accent 5.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent5Color 
  {
    get => ThemeColors["Accent5Color"];
    set => ThemeColors["Accent5Color"] = value;
  }

  /// <summary>
  ///   Accent 6.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent6Color 
  {
    get => ThemeColors["Accent6Color"];
    set => ThemeColors["Accent6Color"] = value;
  }

  /// <summary>
  ///   Hyperlink.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Hyperlink 
  {
    get => ThemeColors["Hyperlink"];
    set => ThemeColors["Hyperlink"] = value;
  }

  /// <summary>
  ///   Followed Hyperlink.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? FollowedHyperlinkColor 
  {
    get => ThemeColors["FollowedHyperlinkColor"];
    set => ThemeColors["FollowedHyperlinkColor"] = value;
  }

  #endregion

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}