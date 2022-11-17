namespace DocumentModel.Drawing.Diagrams;

public interface IScene3D // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.ICamera? Camera { get ; set; }

  public DocumentModel.Drawing.ILightRig? LightRig { get ; set; }

  public IBackdrop? Backdrop { get ; set; }

  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }

}
