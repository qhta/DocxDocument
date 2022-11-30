namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the ShapeProperties Class.
/// </summary>
public interface IShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public DocumentModel.Drawing.BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  public DocumentModel.Drawing.ITransform2D? Transform2D { get ; set; }
  
  public DocumentModel.Drawing.ICustomGeometry? CustomGeometry { get ; set; }
  
  public DocumentModel.Drawing.IPresetGeometry? PresetGeometry { get ; set; }
  
  public System.Boolean? NoFill { get ; set; }
  
  public DocumentModel.Drawing.ISolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawing.IGradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawing.IBlipFill? BlipFill { get ; set; }
  
  public DocumentModel.Drawing.IPatternFill? PatternFill { get ; set; }
  
  public System.Boolean? GroupFill { get ; set; }
  
  public DocumentModel.Drawing.IOutline? Outline { get ; set; }
  
  public DocumentModel.Drawing.IEffectList? EffectList { get ; set; }
  
  public DocumentModel.Drawing.IEffectDag? EffectDag { get ; set; }
  
  public DocumentModel.Drawing.IScene3DType? Scene3DType { get ; set; }
  
  public DocumentModel.Drawing.IShape3DType? Shape3DType { get ; set; }
  
  public DocumentModel.Drawing.IShapePropertiesExtensionList? ShapePropertiesExtensionList { get ; set; }
  
}
