namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the HeaderFooter Class.
/// </summary>
public partial interface HeaderFooter
{
  /// <summary>
  /// alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? AlignWithMargins { get; set; }
  
  /// <summary>
  /// differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? DifferentOddEven { get; set; }
  
  /// <summary>
  /// differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? DifferentFirst { get; set; }
  
  /// <summary>
  /// OddHeaderXsdstring.
  /// </summary>
  public String? OddHeaderXsdstring { get; set; }
  
  /// <summary>
  /// OddFooterXsdstring.
  /// </summary>
  public String? OddFooterXsdstring { get; set; }
  
  /// <summary>
  /// EvenHeaderXsdstring.
  /// </summary>
  public String? EvenHeaderXsdstring { get; set; }
  
  /// <summary>
  /// EvenFooterXsdstring.
  /// </summary>
  public String? EvenFooterXsdstring { get; set; }
  
  /// <summary>
  /// FirstHeaderXsdstring.
  /// </summary>
  public String? FirstHeaderXsdstring { get; set; }
  
  /// <summary>
  /// FirstFooterXsdstring.
  /// </summary>
  public String? FirstFooterXsdstring { get; set; }
  
}
