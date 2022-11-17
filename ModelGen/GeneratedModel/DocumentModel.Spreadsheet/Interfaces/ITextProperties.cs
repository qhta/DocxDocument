namespace DocumentModel.Spreadsheet;

public interface ITextProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? Prompt { get ; set; }
  
  public FileType? FileType { get ; set; }
  
  public uint? CodePage { get ; set; }
  
  public string? TextCharacterSet { get ; set; }
  
  public uint? FirstRow { get ; set; }
  
  public string? SourceFile { get ; set; }
  
  public bool? Delimited { get ; set; }
  
  public string? Decimal { get ; set; }
  
  public string? Thousands { get ; set; }
  
  public bool? TabAsDelimiter { get ; set; }
  
  public bool? Space { get ; set; }
  
  public bool? Comma { get ; set; }
  
  public bool? Semicolon { get ; set; }
  
  public bool? Consecutive { get ; set; }
  
  public Qualifier? Qualifier { get ; set; }
  
  public string? Delimiter { get ; set; }
  
  public ITextFields? TextFields { get ; set; }
  
}
