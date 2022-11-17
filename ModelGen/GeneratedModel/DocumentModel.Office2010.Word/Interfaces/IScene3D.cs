namespace DocumentModel.Office2010.Word;

public interface IScene3D // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2010.Word.ICamera? Camera { get ; set; }
  
  public DocumentModel.Office2010.Word.ILightRig? LightRig { get ; set; }
  
}
