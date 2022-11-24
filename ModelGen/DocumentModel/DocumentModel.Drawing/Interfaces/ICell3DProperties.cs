namespace DocumentModel.Drawing;

/// <summary>
/// Cell 3-D.
/// </summary>
public interface ICell3DProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Material
  /// </summary>
  public PresetMaterialTypeValues? PresetMaterial { get ; set; }
  
  /// <summary>
  /// Bevel.
  /// </summary>
  public IBevel? Bevel { get ; set; }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public ILightRig? LightRig { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
