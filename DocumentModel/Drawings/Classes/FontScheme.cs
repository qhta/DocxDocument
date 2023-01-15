namespace DocumentModel.Drawings;

/// <summary>
///   Font Scheme.
/// </summary>
public class FontScheme
{
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   Major Font.
  /// </summary>
  public MajorFont? MajorFont { get; set; }

  /// <summary>
  ///   Minor fonts.
  /// </summary>
  public MinorFont? MinorFont { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}