namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a fill overlay effect. A fill overlay can be used to specify an additional fill for an object and blend the two fills together.
/// </summary>
public partial class FillOverlay
{
  
  /// <summary>
  ///   Specifies how to blend the fill with the base effect.
  /// </summary>
  public DocumentModel.Drawings.BlendMode? Blend { get; set; }
  
  
  /// <summary>
  ///   NoFill.
  /// </summary>
  public DocumentModel.Drawings.NoFill? NoFill { get; set; }
  
  
  /// <summary>
  ///   SolidFill.
  /// </summary>
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  
  /// <summary>
  ///   GradientFill.
  /// </summary>
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  
  /// <summary>
  ///   BlipFill.
  /// </summary>
  public DocumentModel.Drawings.BlipFill? BlipFill { get; set; }
  
  
  /// <summary>
  ///   Pattern Fill.
  /// </summary>
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  
  /// <summary>
  ///   Group Fill.
  /// </summary>
  public DocumentModel.Drawings.GroupFill? GroupFill { get; set; }
  
}
