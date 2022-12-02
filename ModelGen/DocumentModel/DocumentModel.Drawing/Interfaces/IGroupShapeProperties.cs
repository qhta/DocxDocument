namespace DocumentModel.Drawing;

/// <summary>
/// Group Shape Properties.
/// </summary>
public interface IGroupShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Grouped Objects.
  /// </summary>
  public ITransformGroup? TransformGroup { get ; set; }
  
  public Boolean? NoFill { get ; set; }
  
  public ISolidFill? SolidFill { get ; set; }
  
  public IGradientFill? GradientFill { get ; set; }
  
  public IBlipFill? BlipFill { get ; set; }
  
  public IPatternFill? PatternFill { get ; set; }
  
  public Boolean? GroupFill { get ; set; }
  
  public IEffectList? EffectList { get ; set; }
  
  public IEffectDag? EffectDag { get ; set; }
  
  public IScene3DType? Scene3DType { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
