namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a Color Change Effect. Instances of clrFrom are replaced with instances of clrTo.
/// </summary>
public partial class ColorChange
{
  
  /// <summary>
  ///   Specifies whether alpha values are considered for the effect. Effect alpha values are considered if useA is true, else they are ignored.
  /// </summary>
  public Boolean? UseAlpha { get; set; }
  
  
  /// <summary>
  ///   Change Color From.
  /// </summary>
  public DMD.ColorFrom? ColorFrom { get; set; }
  
  
  /// <summary>
  ///   Change Color To.
  /// </summary>
  public DMD.ColorTo? ColorTo { get; set; }
  
}
