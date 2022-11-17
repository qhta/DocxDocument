namespace DocumentModel.Office2019.Drawing.Model3D;

public interface IBlip // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Embed { get ; set; }
  
  public string? Link { get ; set; }
  
  public BlipCompression? CompressionState { get ; set; }
  
}
