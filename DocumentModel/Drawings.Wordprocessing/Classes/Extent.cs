namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Inline Drawing Object Extents.
/// </summary>
public class Extent: ModelElement
{
  /// <summary>
  ///   Extent Length
  /// </summary>
  public Int64? Cx { get; set; }

  /// <summary>
  ///   Extent Width
  /// </summary>
  public Int64? Cy { get; set; }
}