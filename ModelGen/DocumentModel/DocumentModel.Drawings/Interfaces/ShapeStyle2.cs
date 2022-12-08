namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeStyle Class.
/// </summary>
public interface ShapeStyle2
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public LineReference1? LineReference { get ; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public FillReference1? FillReference { get ; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public EffectReference2? EffectReference { get ; set; }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public FontReference2? FontReference { get ; set; }
  
}
