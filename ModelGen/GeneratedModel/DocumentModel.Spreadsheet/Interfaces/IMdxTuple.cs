namespace DocumentModel.Spreadsheet;

public interface IMdxTuple // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? MemberIndexCount { get ; set; }
  
  public string? CultureCurrency { get ; set; }
  
  public uint? FormattingStringIndex { get ; set; }
  
  public uint? FormatIndex { get ; set; }
  
  public IHexBinaryValue? BackgroundColor { get ; set; }
  
  public IHexBinaryValue? ForegroundColor { get ; set; }
  
  public bool? Italic { get ; set; }
  
  public bool? Underline { get ; set; }
  
  public bool? Strikethrough { get ; set; }
  
  public bool? Bold { get ; set; }
  
}
