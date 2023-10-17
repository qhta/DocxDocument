namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a luminance effect. Brightness linearly shifts all colors closer to white or black. Contrast scales all colors to be either closer or further apart.
/// </summary>
public partial class LuminanceEffect
{
  
  /// <summary>
  ///   Specifies the percent to change the brightness.
  /// </summary>
  public Int32? Brightness { get; set; }
  
  
  /// <summary>
  ///   Specifies the percent to change the contrast.
  /// </summary>
  public Int32? Contrast { get; set; }
  
}
