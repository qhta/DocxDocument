using DocumentFormat.OpenXml;

namespace DocxDocument.Model;

/// <summary>
/// Defines the ColorSchemeIndexValues enumeration.
/// </summary>
public enum ColorSchemeIndex
{
  /// <summary>
  /// Dark 1 Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "dark1".</para>
  /// </summary>
  [EnumString("dark1")]
  Dark1,
  /// <summary>
  /// Light 1 Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "light1".</para>
  /// </summary>
  [EnumString("light1")]
  Light1,
  /// <summary>
  /// Dark 2 Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "dark2".</para>
  /// </summary>
  [EnumString("dark2")]
  Dark2,
  /// <summary>
  /// Light 2 Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "light2".</para>
  /// </summary>
  [EnumString("light2")]
  Light2,
  /// <summary>
  /// Accent 1 Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "accent1".</para>
  /// </summary>
  [EnumString("accent1")]
  Accent1,
  /// <summary>
  /// Accent 2 Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "accent2".</para>
  /// </summary>
  [EnumString("accent2")]
  Accent2,
  /// <summary>
  /// Accent 3 Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "accent3".</para>
  /// </summary>
  [EnumString("accent3")]
  Accent3,
  /// <summary>
  /// Accent4 Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "accent4".</para>
  /// </summary>
  [EnumString("accent4")]
  Accent4,
  /// <summary>
  /// Accent5 Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "accent5".</para>
  /// </summary>
  [EnumString("accent5")]
  Accent5,
  /// <summary>
  /// Accent 6 Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "accent6".</para>
  /// </summary>
  [EnumString("accent6")]
  Accent6,
  /// <summary>
  /// Hyperlink Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "hyperlink".</para>
  /// </summary>
  [EnumString("hyperlink")]
  Hyperlink,
  /// <summary>
  /// Followed Hyperlink Theme Color Reference.
  /// <para>When the item is serialized out as xml, its value is "followedHyperlink".</para>
  /// </summary>
  [EnumString("followedHyperlink")]
  FollowedHyperlink
}
