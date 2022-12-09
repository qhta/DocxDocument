namespace DocumentModel.Drawings;

/// <summary>
/// Shape Style.
/// </summary>
public interface Style1
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public LineReference2? LineReference { get ; set; }
  
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
  public FontReference1? FontReference { get ; set; }
  
}
