namespace DocumentModel.Spreadsheet;

public interface IGradientFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public Gradient? Type { get ; set; }
  
  public double? Degree { get ; set; }
  
  public double? Left { get ; set; }
  
  public double? Right { get ; set; }
  
  public double? Top { get ; set; }
  
  public double? Bottom { get ; set; }
  
}
