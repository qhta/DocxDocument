namespace DocumentModel.VariantTypes;

public interface IVTClipboardData // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  public int? Format { get ; set; }
  
  public uint? Size { get ; set; }
  
  public string? Text { get ; set; }
  
}
