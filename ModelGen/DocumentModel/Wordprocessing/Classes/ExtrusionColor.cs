namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ExtrusionColor Class.
/// </summary>
public partial class ExtrusionColor
{
  public DocumentModel.HexBinaryValue? RgbColorModelHex { get; set; }
  
  public DocumentModel.Wordprocessing.SchemeColorValues? SchemeColor { get; set; }
  
}
