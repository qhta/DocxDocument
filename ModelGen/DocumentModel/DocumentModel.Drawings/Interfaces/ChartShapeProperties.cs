namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartShapeProperties Class.
/// </summary>
public interface ChartShapeProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  public Transform2D? Transform2D { get ; set; }
  
  public CustomGeometry? CustomGeometry { get ; set; }
  
  public PresetGeometry? PresetGeometry { get ; set; }
  
  public Boolean? NoFill { get ; set; }
  
  public SolidFill? SolidFill { get ; set; }
  
  public GradientFill? GradientFill { get ; set; }
  
  public BlipFill? BlipFill { get ; set; }
  
  public PatternFill? PatternFill { get ; set; }
  
  public Outline? Outline { get ; set; }
  
  public EffectList? EffectList { get ; set; }
  
  public EffectDag? EffectDag { get ; set; }
  
  public Scene3DType? Scene3DType { get ; set; }
  
  public Shape3DType? Shape3DType { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
