namespace DocumentModel.Drawings;

/// <summary>
/// Fill Overlay Effect.
/// </summary>
public interface FillOverlay
{
  /// <summary>
  /// Blend
  /// </summary>
  public BlendMode? Blend { get ; set; }
  
  /// <summary>
  /// NoFill.
  /// </summary>
  public Boolean? NoFill { get ; set; }
  
  /// <summary>
  /// SolidFill.
  /// </summary>
  public SolidFill? SolidFill { get ; set; }
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  public GradientFill? GradientFill { get ; set; }
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  public BlipFill? BlipFill { get ; set; }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  public PatternFill? PatternFill { get ; set; }
  
  /// <summary>
  /// Group Fill.
  /// </summary>
  public Boolean? GroupFill { get ; set; }
  
}
