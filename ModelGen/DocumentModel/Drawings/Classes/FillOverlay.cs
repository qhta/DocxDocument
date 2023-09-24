namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a fill overlay effect. A fill overlay can be used to specify an additional fill for an object and blend the two fills together.
/// </summary>
public partial class FillOverlay
{
  
  /// <summary>
  ///   Specifies how to blend the fill with the base effect.
  /// </summary>
  public BlendMode? Blend { get; set; }
  
  
  /// <summary>
  ///   NoFill.
  /// </summary>
  public Boolean? NoFill { get; set; }
  
  
  /// <summary>
  ///   SolidFill.
  /// </summary>
  public SolidFill? SolidFill { get; set; }
  
  
  /// <summary>
  ///   GradientFill.
  /// </summary>
  public GradientFill? GradientFill { get; set; }
  
  
  /// <summary>
  ///   BlipFill.
  /// </summary>
  public BlipFill? BlipFill { get; set; }
  
  
  /// <summary>
  ///   Pattern Fill.
  /// </summary>
  public PatternFill? PatternFill { get; set; }
  
  
  /// <summary>
  ///   Group Fill.
  /// </summary>
  public Boolean? GroupFill { get; set; }
  
}
