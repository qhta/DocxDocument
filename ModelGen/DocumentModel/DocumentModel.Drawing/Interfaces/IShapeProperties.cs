namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ShapeProperties Class.
/// </summary>
public interface IShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  public ITransform2D? Transform2D { get ; set; }
  
  public ICustomGeometry? CustomGeometry { get ; set; }
  
  public IPresetGeometry? PresetGeometry { get ; set; }
  
  public Boolean? NoFill { get ; set; }
  
  public ISolidFill? SolidFill { get ; set; }
  
  public IGradientFill? GradientFill { get ; set; }
  
  public IBlipFill? BlipFill { get ; set; }
  
  public IPatternFill? PatternFill { get ; set; }
  
  public Boolean? GroupFill { get ; set; }
  
  public IOutline? Outline { get ; set; }
  
  public IEffectList? EffectList { get ; set; }
  
  public IEffectDag? EffectDag { get ; set; }
  
  public IScene3DType? Scene3DType { get ; set; }
  
  public IShape3DType? Shape3DType { get ; set; }
  
  public IShapePropertiesExtensionList? ShapePropertiesExtensionList { get ; set; }
  
}
