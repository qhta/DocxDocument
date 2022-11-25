namespace DocumentModel.Drawing;

/// <summary>
/// Cell 3-D.
/// </summary>
public interface ICell3DProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Material
  /// </summary>
  public DocumentModel.Drawing.PresetMaterialTypeKind? PresetMaterial { get ; set; }
  
  /// <summary>
  /// Bevel.
  /// </summary>
  public DocumentModel.Drawing.IBevelType? Bevel { get ; set; }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public DocumentModel.Drawing.ILightRig? LightRig { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
