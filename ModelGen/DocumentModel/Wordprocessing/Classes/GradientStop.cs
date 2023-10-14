namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a gradient stop. A gradient stop consists of a position where the stop appears in the color band.
/// </summary>
public partial class GradientStop
{
  
  /// <summary>
  ///   pos, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? StopPosition { get; set; }
  
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public DM.HexBinary? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColorKind? SchemeColor { get; set; }
  
}
