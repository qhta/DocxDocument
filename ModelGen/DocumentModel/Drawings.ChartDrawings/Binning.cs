namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the Binning Class.
/// </summary>
public partial class Binning
{
  
  /// <summary>
  ///   underflow, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Underflow { get; set; }
  
  
  /// <summary>
  ///   overflow, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Overflow { get; set; }
  
  
  /// <summary>
  ///   Xsddouble.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.Xsddouble? Xsddouble { get; set; }
  
  
  /// <summary>
  ///   BinCountXsdunsignedInt.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.BinCountXsdunsignedInt? BinCountXsdunsignedInt { get; set; }
  
}
