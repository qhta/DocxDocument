namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IText // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2016.Drawing.ChartDrawing.ITextData? TextData { get ; set; }

  public IRichTextBody? RichTextBody { get ; set; }

}
