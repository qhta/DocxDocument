namespace DocumentModel.Drawing.Charts;

public interface ITitle // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Charts.IChartText? ChartText { get ; set; }
  
  public DocumentModel.Drawing.Charts.ILayout? Layout { get ; set; }
  
  public IOverlay? Overlay { get ; set; }
  
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.ITextProperties? TextProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
