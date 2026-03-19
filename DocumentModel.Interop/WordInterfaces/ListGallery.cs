namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single gallery of list formats.
/// </summary>
public partial interface ListGallery : InteropObject
{
  /// <summary>
  /// The list templates.
  /// </summary>
  public ListTemplates ListTemplates { get; }
}
