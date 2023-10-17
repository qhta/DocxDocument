namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ContourColor Class.
/// </summary>
public partial class ContourColor
{
  public DM.HexBinary? RgbColorModelHex { get; set; }
  
  public DocumentModel.Wordprocessing.SchemeColorKind? SchemeColor { get; set; }
  
}
