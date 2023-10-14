namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ExtrusionColor Class.
/// </summary>
public partial class ExtrusionColor
{
  public DM.HexBinary? RgbColorModelHex { get; set; }
  
  public DocumentModel.Wordprocessing.SchemeColorKind? SchemeColor { get; set; }
  
}
