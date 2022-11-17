namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IPrintSettings // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2016.Drawing.ChartDrawing.IHeaderFooter? HeaderFooter { get ; set; }

  public DocumentModel.Office2016.Drawing.ChartDrawing.IPageMargins? PageMargins { get ; set; }

  public DocumentModel.Office2016.Drawing.ChartDrawing.IPageSetup? PageSetup { get ; set; }

}
