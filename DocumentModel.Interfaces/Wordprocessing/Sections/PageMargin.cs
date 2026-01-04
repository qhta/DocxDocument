namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PageMargin Class.
/// </summary>
public interface PageMargin: IModelElement, ISectionPropertiesContent
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