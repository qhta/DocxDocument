namespace DocumentModel.InkML;

/// <summary>
/// Defines the InkSource Class.
/// </summary>
public interface IInkSource // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// manufacturer
  /// </summary>
  public System.String? Manufacturer { get ; set; }
  
  /// <summary>
  /// model
  /// </summary>
  public System.String? Model { get ; set; }
  
  /// <summary>
  /// serialNo
  /// </summary>
  public System.String? SerialNo { get ; set; }
  
  /// <summary>
  /// specificationRef
  /// </summary>
  public System.String? SpecificationRef { get ; set; }
  
  /// <summary>
  /// description
  /// </summary>
  public System.String? Description { get ; set; }
  
  /// <summary>
  /// TraceFormat.
  /// </summary>
  public DocumentModel.InkML.ITraceFormat? TraceFormat { get ; set; }
  
  /// <summary>
  /// SampleRate.
  /// </summary>
  public DocumentModel.InkML.ISampleRate? SampleRate { get ; set; }
  
  /// <summary>
  /// Latency.
  /// </summary>
  public DocumentModel.InkML.ILatency? Latency { get ; set; }
  
  /// <summary>
  /// ActiveArea.
  /// </summary>
  public DocumentModel.InkML.IActiveArea? ActiveArea { get ; set; }
  
}
