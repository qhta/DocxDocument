namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ColorType Class.
/// </summary>
public partial class ColorType
{
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public HexBinary? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public SchemeColorKind? SchemeColor { get; set; }
  
}
