namespace DocumentModel.Drawing;

/// <summary>
/// Cell 3-D.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBevel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILightRig))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public class Cell3DProperties: ICell3DProperties
{
  /// <summary>
  /// Preset Material
  /// </summary>
  public DocumentModel.Drawing.PresetMaterialTypeValues? PresetMaterial
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bevel.
  /// </summary>
  public IBevel? Bevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public DocumentModel.Drawing.ILightRig? LightRig
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
