namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IFont Scheme.
/// </summary>
public class FontScheme: ModelElement
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Major IFont.
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
