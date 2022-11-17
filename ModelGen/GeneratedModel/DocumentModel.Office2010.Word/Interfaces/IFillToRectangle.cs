namespace DocumentModel.Office2010.Word;

public interface IFillToRectangle // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public int? Left { get ; set; }
  
  public int? Top { get ; set; }
  
  public int? Right { get ; set; }
  
  public int? Bottom { get ; set; }
  
}
