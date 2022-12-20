namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
public partial interface ContourColor
{
  public DocumentModel.Wordprocessing.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DocumentModel.Wordprocessing.SchemeColor? SchemeColor { get; set; }
  
}
