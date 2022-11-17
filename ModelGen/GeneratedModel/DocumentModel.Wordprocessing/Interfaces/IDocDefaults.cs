namespace DocumentModel.Wordprocessing;

public interface IDocDefaults // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IRunPropertiesDefault? RunPropertiesDefault { get ; set; }
  
  public IParagraphPropertiesDefault? ParagraphPropertiesDefault { get ; set; }
  
}
