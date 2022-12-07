namespace DocumentModel.Drawings;

/// <summary>
/// Fill.
/// </summary>
public interface Fill
{
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
  public BlipFill1? BlipFill { get ; set; }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  public PatternFill? PatternFill { get ; set; }
  
}
