namespace DocumentModel.Drawing;

public interface IFillToRectangle // : DocumentFormat.OpenXml.Drawing.RelativeRectangleType
{
  public int? Left { get ; set; }
  
  public int? Top { get ; set; }
  
  public int? Right { get ; set; }
  
  public int? Bottom { get ; set; }
  
}
