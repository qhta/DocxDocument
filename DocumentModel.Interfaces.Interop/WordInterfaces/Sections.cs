namespace DocumentModel.Interop;

/// <summary>
/// A collection of Section objects in a selection, range, or document.
/// </summary>
public partial interface Sections : InteropObject, InteropCollection<Section>
{
  /// <summary>
  /// The first.
  /// </summary>
  public Section First { get; }

  /// <summary>
  /// The last.
  /// </summary>
  public Section Last { get; }

  /// <summary>
  /// The page setup.
  /// </summary>
  public PageSetup PageSetup { get; set; }
}
