namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the HeaderFooter Class.
/// </summary>
public partial class HeaderFooter
{
  
  /// <summary>
  ///   alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? AlignWithMargins { get; set; }
  
  
  /// <summary>
  ///   differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? DifferentOddEven { get; set; }
  
  
  /// <summary>
  ///   differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? DifferentFirst { get; set; }
  
  
  /// <summary>
  ///   OddHeaderXsdstring.
  /// </summary>
  public DMDCD16.OddHeaderXsdstring? OddHeaderXsdstring { get; set; }
  
  
  /// <summary>
  ///   OddFooterXsdstring.
  /// </summary>
  public DMDCD16.OddFooterXsdstring? OddFooterXsdstring { get; set; }
  
  
  /// <summary>
  ///   EvenHeaderXsdstring.
  /// </summary>
  public DMDCD16.EvenHeaderXsdstring? EvenHeaderXsdstring { get; set; }
  
  
  /// <summary>
  ///   EvenFooterXsdstring.
  /// </summary>
  public DMDCD16.EvenFooterXsdstring? EvenFooterXsdstring { get; set; }
  
  
  /// <summary>
  ///   FirstHeaderXsdstring.
  /// </summary>
  public DMDCD16.FirstHeaderXsdstring? FirstHeaderXsdstring { get; set; }
  
  
  /// <summary>
  ///   FirstFooterXsdstring.
  /// </summary>
  public DMDCD16.FirstFooterXsdstring? FirstFooterXsdstring { get; set; }
  
}
