namespace DocumentModel.Presentation;

public interface IStartSoundAction // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? Loop { get ; set; }
  
  public ISound? Sound { get ; set; }
  
}
