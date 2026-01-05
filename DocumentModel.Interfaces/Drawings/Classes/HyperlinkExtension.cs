namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HyperlinkExtension interface.
/// </summary>
public interface HyperlinkExtension:
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public HyperlinkColorEnum? HyperlinkColor { get; set; }
}