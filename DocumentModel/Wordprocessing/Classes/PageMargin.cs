namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PageMargin Class.
/// </summary>
public class PageMargin: ModelElement, ISectionPropertiesElement
{
  /// <summary>
  ///   Top Margin Spacing
  /// </summary>
  public DXA? Top { get; set; }

  /// <summary>
  ///   Right Margin Spacing
  /// </summary>
  public DXA? Right { get; set; }

  /// <summary>
  ///   Page Bottom Spacing
  /// </summary>
  public DXA? Bottom { get; set; }

  /// <summary>
  ///   Left Margin Spacing
  /// </summary>
  public DXA? Left { get; set; }

  /// <summary>
  ///   Spacing to Top of Header
  /// </summary>
  public DXA? Header { get; set; }

  /// <summary>
  ///   Spacing to Bottom of Footer
  /// </summary>
  public DXA? Footer { get; set; }

  /// <summary>
  ///   Page Gutter Spacing
  /// </summary>
  public DXA? Gutter { get; set; }
}