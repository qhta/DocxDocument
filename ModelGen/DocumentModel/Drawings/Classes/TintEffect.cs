namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a tint effect. Shifts effect color values towards/away from hue by the specified amount.
/// </summary>
public partial class TintEffect
{
  
  /// <summary>
  ///   Specifies the hue towards which to tint.
  /// </summary>
  public Int32? Hue { get; set; }
  
  
  /// <summary>
  ///   Specifies by how much the color value is shifted.
  /// </summary>
  public Int32? Amount { get; set; }
  
}
