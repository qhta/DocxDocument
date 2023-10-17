namespace DocumentModel.Wordprocessing;


/// <summary>
///   Set of Borders for HTML div.
/// </summary>
public partial class DivBorder
{
  
  /// <summary>
  ///   Top Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.TopBorder? TopBorder { get; set; }
  
  
  /// <summary>
  ///   Left Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.LeftBorder? LeftBorder { get; set; }
  
  
  /// <summary>
  ///   Bottom Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BottomBorder? BottomBorder { get; set; }
  
  
  /// <summary>
  ///   Right Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.RightBorder? RightBorder { get; set; }
  
}
