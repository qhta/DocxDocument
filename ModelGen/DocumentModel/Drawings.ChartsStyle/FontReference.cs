namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the FontReference Class.
/// </summary>
public partial class FontReference
{
  
  /// <summary>
  ///   mods, this property is only available in Office 2013 and later.
  /// </summary>
  public DM.ListOf<String>? Modifiers { get; set; }
  
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DMD.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DMD.HslColor? HslColor { get; set; }
  
  public DMD.SystemColor? SystemColor { get; set; }
  
  public DMD.SchemeColorKind? SchemeColor { get; set; }
  
  public DMD.PresetColorKind? PresetColor { get; set; }
  
  public String? StyleColor { get; set; }
  
}
