namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PageMargin Class.
/// </summary>
public class PageMargin: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   Top Margin Spacing
  /// </summary>
  public ITwips? Top { get; set; }
  /// <summary>
  ///   Right Margin Spacing
  /// </summary>
  public ITwips? Right { get; set; }
  /// <summary>
  ///   Page Bottom Spacing
  /// </summary>
  public ITwips? Bottom { get; set; }
  /// <summary>
  ///   Left Margin Spacing
  /// </summary>
  public ITwips? Left { get; set; }
  /// <summary>
  ///   Spacing to Top of Header
  /// </summary>
  public ITwips? Header { get; set; }
  /// <summary>
  ///   Spacing to Bottom of Footer
  /// </summary>
  public ITwips? Footer { get; set; }
  /// <summary>
  ///   Page Gutter Spacing
  /// </summary>
  public ITwips? Gutter { get; set; }
}