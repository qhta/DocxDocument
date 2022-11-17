namespace DocumentModel.Wordprocessing;

public interface IDrawing // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Wordprocessing.IAnchor? Anchor { get ; set; }

  public IInline? Inline { get ; set; }

}
