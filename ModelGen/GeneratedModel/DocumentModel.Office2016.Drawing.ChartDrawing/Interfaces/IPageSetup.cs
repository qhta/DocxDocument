namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IPageSetup // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? PaperSize { get ; set; }
  
  public uint? FirstPageNumber { get ; set; }
  
  public PageOrientation? Orientation { get ; set; }
  
  public bool? BlackAndWhite { get ; set; }
  
  public bool? Draft { get ; set; }
  
  public bool? UseFirstPageNumber { get ; set; }
  
  public int? HorizontalDpi { get ; set; }
  
  public int? VerticalDpi { get ; set; }
  
  public uint? Copies { get ; set; }
  
}
