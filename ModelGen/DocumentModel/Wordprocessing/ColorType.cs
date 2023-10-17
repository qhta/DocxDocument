namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ColorType Class.
/// </summary>
public partial class ColorType
{
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public DM.HexBinary? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColorKind? SchemeColor { get; set; }
  
}
