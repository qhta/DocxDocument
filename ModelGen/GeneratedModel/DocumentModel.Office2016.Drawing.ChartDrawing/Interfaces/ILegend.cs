namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface ILegend // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public SidePos? Pos { get ; set; }

  public PosAlign? Align { get ; set; }

  public bool? Overlay { get ; set; }

  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }

  public ITxPrTextBody? TxPrTextBody { get ; set; }

  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }

}
