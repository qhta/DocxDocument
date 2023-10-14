namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the MarkerLayoutProperties Class.
/// </summary>
public partial class MarkerLayoutProperties
{
  
  /// <summary>
  ///   symbol, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.MarkerStyle? Symbol { get; set; }
  
  
  /// <summary>
  ///   size, this property is only available in Office 2013 and later.
  /// </summary>
  public Byte? Size { get; set; }
  
}
