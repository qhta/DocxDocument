namespace DocumentModel.Vml.Office;

public interface IColorMenu // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
  public string? StrokeColor { get ; set; }
  
  public string? FillColor { get ; set; }
  
  public string? ShadowColor { get ; set; }
  
  public string? ExtrusionColor { get ; set; }
  
}
