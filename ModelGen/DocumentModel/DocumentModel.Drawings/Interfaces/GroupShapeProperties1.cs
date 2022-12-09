namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeProperties Class.
/// </summary>
public interface GroupShapeProperties1
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Grouped Objects.
  /// </summary>
  public TransformGroup? TransformGroup { get ; set; }
  
  public Boolean? NoFill { get ; set; }
  
  public SolidFill? SolidFill { get ; set; }
  
  public GradientFill? GradientFill { get ; set; }
  
  public BlipFill1? BlipFill { get ; set; }
  
  public PatternFill? PatternFill { get ; set; }
  
  public Boolean? GroupFill { get ; set; }
  
  public EffectList? EffectList { get ; set; }
  
  public EffectDag? EffectDag { get ; set; }
  
  public Scene3DType? Scene3DType { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
