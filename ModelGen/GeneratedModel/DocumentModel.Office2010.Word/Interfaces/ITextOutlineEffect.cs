namespace DocumentModel.Office2010.Word;

public interface ITextOutlineEffect // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? LineWidth { get ; set; }
  
  public DocumentModel.Office2010.Word.LineCap? CapType { get ; set; }
  
  public DocumentModel.Office2010.Word.CompoundLine? Compound { get ; set; }
  
  public DocumentModel.Office2010.Word.PenAlignment? Alignment { get ; set; }
  
}
