namespace DocumentModel.Office2010.Word;

public interface ILightRig // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public LightRigType? LightRigType { get ; set; }
  
  public DocumentModel.Office2010.Word.LightRigDirection? LightDirectionType { get ; set; }
  
  public ISphereCoordinates? SphereCoordinates { get ; set; }
  
}
