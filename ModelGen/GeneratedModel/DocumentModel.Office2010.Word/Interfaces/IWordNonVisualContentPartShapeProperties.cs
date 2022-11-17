namespace DocumentModel.Office2010.Word;

public interface IWordNonVisualContentPartShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2010.Word.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Office2010.Word.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }

}
