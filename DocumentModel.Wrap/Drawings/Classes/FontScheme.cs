namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Font Scheme.
/// </summary>
public class FontScheme: ModelElement
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

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}