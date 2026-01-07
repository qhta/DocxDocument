namespace DocumentModel.Drawings;

/// <summary>
///   Represents a font scheme, including its name and definitions for major and minor fonts.
/// </summary>
public interface FontScheme : ExtendableElement
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
}