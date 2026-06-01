namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Entry Categorization.
/// </summary>
public class ICategory: ModelElement
{
  /// <summary>
  ///   ICategory Associated With Entry.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Gallery Associated With Entry.
  /// </summary>
  public DocPartGalleryKind? Gallery { get; set; }
}
