namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Entry Categorization.
/// </summary>
public class Category: ModelElement
{
  /// <summary>
  ///   Category Associated With Entry.
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   Gallery Associated With Entry.
  /// </summary>
  public DocPartGalleryKind? Gallery { get; set; }
}