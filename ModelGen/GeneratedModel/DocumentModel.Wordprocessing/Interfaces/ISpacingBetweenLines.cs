namespace DocumentModel.Wordprocessing;

public interface ISpacingBetweenLines // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Before { get ; set; }
  
  public int? BeforeLines { get ; set; }
  
  public bool? BeforeAutoSpacing { get ; set; }
  
  public string? After { get ; set; }
  
  public int? AfterLines { get ; set; }
  
  public bool? AfterAutoSpacing { get ; set; }
  
  public string? Line { get ; set; }
  
  public LineSpacingRule? LineRule { get ; set; }
  
}
