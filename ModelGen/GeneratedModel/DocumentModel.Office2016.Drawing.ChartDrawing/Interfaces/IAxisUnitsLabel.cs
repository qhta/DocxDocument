namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IAxisUnitsLabel // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2016.Drawing.ChartDrawing.IText? Text { get ; set; }

  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }

  public ITxPrTextBody? TxPrTextBody { get ; set; }

  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }

}
