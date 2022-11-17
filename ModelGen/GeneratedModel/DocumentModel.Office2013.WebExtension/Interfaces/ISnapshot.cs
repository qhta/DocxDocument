namespace DocumentModel.Office2013.WebExtension;

public interface ISnapshot // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Embed { get ; set; }
  
  public string? Link { get ; set; }
  
  public BlipCompression? CompressionState { get ; set; }
  
}
