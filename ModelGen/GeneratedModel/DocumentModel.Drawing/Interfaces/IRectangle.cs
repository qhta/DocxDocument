namespace DocumentModel.Drawing;

public interface IRectangle // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Left { get ; set; }
  
  public string? Top { get ; set; }
  
  public string? Right { get ; set; }
  
  public string? Bottom { get ; set; }
  
}
