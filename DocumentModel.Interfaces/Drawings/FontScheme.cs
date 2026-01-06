namespace DocumentModel.Drawings;

/// <summary>
///   Font Scheme.
/// </summary>
public interface FontScheme: ExtendableElement
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Major Font.
  /// </summary>
  public MajorFont? MajorFont { get; set; }
  /// <summary>
  ///   Minor fonts.
  /// </summary>
  public MinorFont? MinorFont { get; set; }
}