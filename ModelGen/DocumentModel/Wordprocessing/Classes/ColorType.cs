namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ColorType Class.
/// </summary>
public partial class ColorType
{
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public DocumentModel.HexBinaryValue? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColorValues? SchemeColor { get; set; }
  
}
