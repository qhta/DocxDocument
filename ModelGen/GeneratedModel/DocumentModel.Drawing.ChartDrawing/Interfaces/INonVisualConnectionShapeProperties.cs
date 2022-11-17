namespace DocumentModel.Drawing.ChartDrawing;

public interface INonVisualConnectionShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IConnectionShapeLocks? ConnectionShapeLocks { get ; set; }

  public IStartConnection? StartConnection { get ; set; }

  public IEndConnection? EndConnection { get ; set; }

  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }

}
