namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the PageMargin Class.
/// </summary>
public class PageMargin: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   Top Margin Spacing
  /// </summary>
  public Twips? Top { get; set; }

  /// <summary>
  ///   Right Margin Spacing
  /// </summary>
  public Twips? Right { get; set; }

  /// <summary>
  ///   IPage Bottom Spacing
  /// </summary>
  public Twips? Bottom { get; set; }

  /// <summary>
  ///   Left Margin Spacing
  /// </summary>
  public Twips? Left { get; set; }

  /// <summary>
  ///   Spacing Ito Top of Header
  /// </summary>
  public Twips? Header { get; set; }

  /// <summary>
  ///   Spacing Ito Bottom of Footer
  /// </summary>
  public Twips? Footer { get; set; }

  /// <summary>
  ///   IPage Gutter Spacing
  /// </summary>
  public Twips? Gutter { get; set; }
}
