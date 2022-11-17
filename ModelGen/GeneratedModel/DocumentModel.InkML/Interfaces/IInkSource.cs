namespace DocumentModel.InkML;

public interface IInkSource // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Id { get ; set; }

  public string? Manufacturer { get ; set; }

  public string? Model { get ; set; }

  public string? SerialNo { get ; set; }

  public string? SpecificationRef { get ; set; }

  public string? Description { get ; set; }

  public ITraceFormat? TraceFormat { get ; set; }

  public ISampleRate? SampleRate { get ; set; }

  public ILatency? Latency { get ; set; }

  public IActiveArea? ActiveArea { get ; set; }

}
