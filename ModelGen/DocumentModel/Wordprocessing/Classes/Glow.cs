namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the glow effect, a colored, blurred outline that is added outside the edges of text. By default, text does not have glow.
/// </summary>
public partial class Glow
{
  
  /// <summary>
  ///   rad, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:rad")]
  public Int64? GlowRadius { get; set; }
  
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public DocumentModel.HexBinaryValue? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColorValues? SchemeColor { get; set; }
  
}
