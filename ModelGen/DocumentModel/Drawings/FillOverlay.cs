namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a fill overlay effect. A fill overlay can be used to specify an additional fill for an object and blend the two fills together.
/// </summary>
public partial class FillOverlay
{
  
  /// <summary>
  ///   NoFill.
  /// </summary>
  public DMD.NoFill? NoFill { get; set; }
  
  
  /// <summary>
  ///   SolidFill.
  /// </summary>
  public DMD.SolidFill? SolidFill { get; set; }
  
  
  /// <summary>
  ///   GradientFill.
  /// </summary>
  public DMD.GradientFill? GradientFill { get; set; }
  
  
  /// <summary>
  ///   BlipFill.
  /// </summary>
  public DMD.BlipFill? BlipFill { get; set; }
  
  
  /// <summary>
  ///   Pattern Fill.
  /// </summary>
  public DMD.PatternFill? PatternFill { get; set; }
  
  
  /// <summary>
  ///   Group Fill.
  /// </summary>
  public DMD.GroupFill? GroupFill { get; set; }
  
}
