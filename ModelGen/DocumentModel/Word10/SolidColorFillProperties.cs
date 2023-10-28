namespace DocumentModel.Word10;


/// <summary>
///   This element specifies a color bound to the document’s theme and an optional list of color transforms to apply to the base color.
/// </summary>
public partial class SolidColorFillProperties
{
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public DM.HexBinary? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public DMW10.SchemeColorKind? SchemeColor { get; set; }
  
}
