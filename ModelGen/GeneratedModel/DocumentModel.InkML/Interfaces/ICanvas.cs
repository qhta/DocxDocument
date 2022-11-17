namespace DocumentModel.InkML;

public interface ICanvas // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Id { get ; set; }
  
  public string? TraceFormatRef { get ; set; }
  
  public ITraceFormat? TraceFormat { get ; set; }
  
}
