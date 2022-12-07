namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public interface Shadow
{
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get ; set; }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor { get ; set; }
  
}
