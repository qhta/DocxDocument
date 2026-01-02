namespace DocumentModel.Wordprocessing;

/// <summary>
///   Information About Single HTML div Element.
/// </summary>
public interface IDivElement: IModelElement, ICollectionItem
{
  /// <summary>
  ///   div Data ID
  /// </summary>
  public Int32? Id { get; set; }
  /// <summary>
  ///   Data for HTML blockquote Element.
  /// </summary>
  public bool? IsBlockQuote { get; set; }
  /// <summary>
  ///   Data for HTML body Element.
  /// </summary>
  public bool? IsBody { get; set; }
  /// <summary>
  ///   Left Margin for HTML div.
  /// </summary>
  public ITwips? LeftMargin { get; set; }
  /// <summary>
  ///   Right Margin for HTML div.
  /// </summary>
  public ITwips? RightMargin { get; set; }
  /// <summary>
  ///   Top Margin for HTML div.
  /// </summary>
  public ITwips? TopMargin { get; set; }
  /// <summary>
  ///   Bottom Margin for HTML div.
  /// </summary>
  public ITwips? BottomMargin { get; set; }
  /// <summary>
  ///   Set of Borders for HTML div.
  /// </summary>
  public IDivBorder? DivBorder { get; set; }
  /// <summary>
  /// Child divs.
  /// </summary>
  public IDivChildren? Children { get; set; }
}