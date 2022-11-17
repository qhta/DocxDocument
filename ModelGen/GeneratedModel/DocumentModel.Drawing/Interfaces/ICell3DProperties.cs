namespace DocumentModel.Drawing;

public interface ICell3DProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.PresetMaterialType? PresetMaterial { get ; set; }

  public IBevel? Bevel { get ; set; }

  public DocumentModel.Drawing.ILightRig? LightRig { get ; set; }

  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }

}
