namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageBorders Class.
/// </summary>
public partial class PageBorders
{
  
  /// <summary>
  ///   Top Border.
  /// </summary>
  public DMW.TopBorder? TopBorder { get; set; }
  
  
  /// <summary>
  ///   Left Border.
  /// </summary>
  public DMW.LeftBorder? LeftBorder { get; set; }
  
  
  /// <summary>
  ///   Bottom Border.
  /// </summary>
  public DMW.BottomBorder? BottomBorder { get; set; }
  
  
  /// <summary>
  ///   Right Border.
  /// </summary>
  public DMW.RightBorder? RightBorder { get; set; }
  
}
