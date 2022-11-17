namespace DocumentModel.Presentation;

public interface IGraphicElement // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.IDiagram? Diagram { get ; set; }

  public DocumentModel.Drawing.IChart? Chart { get ; set; }

}
