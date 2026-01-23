namespace DocumentModel.Drawings;

/// <summary>
///   Represents a font scheme, including its name and definitions for major and minor fonts.
/// </summary>
public class FontScheme : ModelElement<DXD.FontScheme>, IExtendableElement
{
  /// <summary>
  ///   Name of the font scheme.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Major font definition.
  /// </summary>
  public MajorFont? MajorFont { get; set; }

  /// <summary>
  ///   Minor font definition.
  /// </summary>
  public MinorFont? MinorFont { get; set; }

  /// <summary>
  /// List of extension properties for the font scheme, used for extensibility scenarios.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}