namespace DocumentModel.Drawings.ChartDrawings;


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
  public DocumentModel.Drawings.ChartDrawings.OddHeaderXsdstring? OddHeaderXsdstring { get; set; }
  
  
  /// <summary>
  ///   OddFooterXsdstring.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.OddFooterXsdstring? OddFooterXsdstring { get; set; }
  
  
  /// <summary>
  ///   EvenHeaderXsdstring.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.EvenHeaderXsdstring? EvenHeaderXsdstring { get; set; }
  
  
  /// <summary>
  ///   EvenFooterXsdstring.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.EvenFooterXsdstring? EvenFooterXsdstring { get; set; }
  
  
  /// <summary>
  ///   FirstHeaderXsdstring.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.FirstHeaderXsdstring? FirstHeaderXsdstring { get; set; }
  
  
  /// <summary>
  ///   FirstFooterXsdstring.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.FirstFooterXsdstring? FirstFooterXsdstring { get; set; }
  
}
