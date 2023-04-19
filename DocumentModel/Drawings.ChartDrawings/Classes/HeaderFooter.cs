namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HeaderFooter Class.
/// </summary>
public class HeaderFooter: ModelElement
{
  /// <summary>
  ///   alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? AlignWithMargins { get; set; }

  /// <summary>
  ///   differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? DifferentOddEven { get; set; }

  /// <summary>
  ///   differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? DifferentFirst { get; set; }

  /// <summary>
  ///   OddHeaderXsdstring.
  /// </summary>
  public string? OddHeaderXsdstring { get; set; }

  /// <summary>
  ///   OddFooterXsdstring.
  /// </summary>
  public string? OddFooterXsdstring { get; set; }

  /// <summary>
  ///   EvenHeaderXsdstring.
  /// </summary>
  public string? EvenHeaderXsdstring { get; set; }

  /// <summary>
  ///   EvenFooterXsdstring.
  /// </summary>
  public string? EvenFooterXsdstring { get; set; }

  /// <summary>
  ///   FirstHeaderXsdstring.
  /// </summary>
  public string? FirstHeaderXsdstring { get; set; }

  /// <summary>
  ///   FirstFooterXsdstring.
  /// </summary>
  public string? FirstFooterXsdstring { get; set; }
}