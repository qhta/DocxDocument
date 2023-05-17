namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Information About Single HTML div Element.
/// </summary>
public class Div: ModelElement
{
  /// <summary>
  ///   div Data ID
  /// </summary>
  public Int32? Id { get; set; }

  /// <summary>
  ///   Data for HTML blockquote Element.
  /// </summary>
  public bool? BlockQuote { get; set; }

  /// <summary>
  ///   Data for HTML body Element.
  /// </summary>
  public bool? BodyDiv { get; set; }

  /// <summary>
  ///   Left Margin for HTML div.
  /// </summary>
  public Twips? LeftMarginDiv { get; set; }

  /// <summary>
  ///   Right Margin for HTML div.
  /// </summary>
  public Twips? RightMarginDiv { get; set; }

  /// <summary>
  ///   Top Margin for HTML div.
  /// </summary>
  public Twips? TopMarginDiv { get; set; }

  /// <summary>
  ///   Bottom Margin for HTML div.
  /// </summary>
  public Twips? BottomMarginDiv { get; set; }

  /// <summary>
  ///   Set of Borders for HTML div.
  /// </summary>
  public DivBorder? DivBorder { get; set; }

  /// <summary>
  /// Child divs.
  /// </summary>
  public DivsChildren? Children { get; set; }
}