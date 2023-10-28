namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a reference to a fill style within the style matrix. The idx attribute refers to the index of a fill style or background fill style within the presentation's style matrix, defined by the fmtScheme element.  A value of 0 or 1000 indicates no background, values 1-999 refer to the index of a fill style within the fillStyleLst element, and values 1001 and above refer to the index of a background fill style within the bgFillStyleLst element.  The value 1001 corresponds to the first background fill style, 1002 to the second background fill style, and so on.
/// </summary>
public partial class FillReference
{
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DMD.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DMD.HslColor? HslColor { get; set; }
  
  public DMD.SystemColor? SystemColor { get; set; }
  
  public DMD.SchemeColorKind? SchemeColor { get; set; }
  
  public DMD.PresetColorKind? PresetColor { get; set; }
  
}
