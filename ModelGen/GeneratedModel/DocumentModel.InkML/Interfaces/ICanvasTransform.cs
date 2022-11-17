namespace DocumentModel.InkML;

public interface ICanvasTransform // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Id { get ; set; }
  
  public bool? Invertible { get ; set; }
  
}
