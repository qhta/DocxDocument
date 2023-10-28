namespace DocumentModel.Wordprocessing;


/// <summary>
///   Set of Borders for HTML div.
/// </summary>
public partial class DivBorder
{
  
  /// <summary>
  ///   Top Border for HTML div.
  /// </summary>
  public DMW.TopBorder? TopBorder { get; set; }
  
  
  /// <summary>
  ///   Left Border for HTML div.
  /// </summary>
  public DMW.LeftBorder? LeftBorder { get; set; }
  
  
  /// <summary>
  ///   Bottom Border for HTML div.
  /// </summary>
  public DMW.BottomBorder? BottomBorder { get; set; }
  
  
  /// <summary>
  ///   Right Border for HTML div.
  /// </summary>
  public DMW.RightBorder? RightBorder { get; set; }
  
}
