namespace DocumentModel.Drawing;

public interface ITextShape // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.ITextBody? TextBody { get ; set; }
  
}
