namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageBorders Class.
/// </summary>
public partial class PageBorders
{
  
  /// <summary>
  ///   Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.TopBorder? TopBorder { get; set; }
  
  
  /// <summary>
  ///   Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.LeftBorder? LeftBorder { get; set; }
  
  
  /// <summary>
  ///   Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BottomBorder? BottomBorder { get; set; }
  
  
  /// <summary>
  ///   Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.RightBorder? RightBorder { get; set; }
  
}
