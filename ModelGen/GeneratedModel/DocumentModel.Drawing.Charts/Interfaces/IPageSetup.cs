namespace DocumentModel.Drawing.Charts;

public interface IPageSetup // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? PaperSize { get ; set; }
  
  public int? FirstPageNumber { get ; set; }
  
  public PageSetupOrientation? Orientation { get ; set; }
  
  public bool? BlackAndWhite { get ; set; }
  
  public bool? Draft { get ; set; }
  
  public bool? UseFirstPageNumber { get ; set; }
  
  public int? HorizontalDpi { get ; set; }
  
  public int? VerticalDpi { get ; set; }
  
  public uint? Copies { get ; set; }
  
}
