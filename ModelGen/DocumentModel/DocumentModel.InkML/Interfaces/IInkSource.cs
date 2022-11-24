namespace DocumentModel.InkML;

/// <summary>
/// Defines the InkSource Class.
/// </summary>
public interface IInkSource // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// manufacturer
  /// </summary>
  public String? Manufacturer { get ; set; }
  
  /// <summary>
  /// model
  /// </summary>
  public String? Model { get ; set; }
  
  /// <summary>
  /// serialNo
  /// </summary>
  public String? SerialNo { get ; set; }
  
  /// <summary>
  /// specificationRef
  /// </summary>
  public String? SpecificationRef { get ; set; }
  
  /// <summary>
  /// description
  /// </summary>
  public String? Description { get ; set; }
  
  /// <summary>
  /// TraceFormat.
  /// </summary>
  public ITraceFormat? TraceFormat { get ; set; }
  
  /// <summary>
  /// SampleRate.
  /// </summary>
  public ISampleRate? SampleRate { get ; set; }
  
  /// <summary>
  /// Latency.
  /// </summary>
  public ILatency? Latency { get ; set; }
  
  /// <summary>
  /// ActiveArea.
  /// </summary>
  public IActiveArea? ActiveArea { get ; set; }
  
}
