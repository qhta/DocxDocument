namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  ///   Page Bottom Spacing
  /// </summary>
  public Twips? Bottom { get; set; }

  /// <summary>
  ///   Left Margin Spacing
  /// </summary>
  public Twips? Left { get; set; }

  /// <summary>
  ///   Spacing to Top of Header
  /// </summary>
  public Twips? Header { get; set; }

  /// <summary>
  ///   Spacing to Bottom of Footer
  /// </summary>
  public Twips? Footer { get; set; }

  /// <summary>
  ///   Page Gutter Spacing
  /// </summary>
  public Twips? Gutter { get; set; }
}