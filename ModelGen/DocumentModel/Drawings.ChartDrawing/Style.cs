namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Shape Style.
/// </summary>
public partial class Style
{
  
  /// <summary>
  ///   LineReference.
  /// </summary>
  public DMD.LineReference? LineReference { get; set; }
  
  
  /// <summary>
  ///   FillReference.
  /// </summary>
  public DMD.FillReference? FillReference { get; set; }
  
  
  /// <summary>
  ///   EffectReference.
  /// </summary>
  public DMD.EffectReference? EffectReference { get; set; }
  
  
  /// <summary>
  ///   Font Reference.
  /// </summary>
  public DMD.FontReference? FontReference { get; set; }
  
}
