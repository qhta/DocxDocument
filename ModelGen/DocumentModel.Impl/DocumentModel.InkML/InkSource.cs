namespace DocumentModel.InkML;

/// <summary>
/// Defines the InkSource Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IActiveArea))]
[ChildElementInfo(typeof(DocumentModel.InkML.IChannelProperties))]
[ChildElementInfo(typeof(DocumentModel.InkML.ILatency))]
[ChildElementInfo(typeof(DocumentModel.InkML.ISampleRate))]
[ChildElementInfo(typeof(DocumentModel.InkML.ISourceProperty))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITraceFormat))]
public class InkSource: IInkSource
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// manufacturer
  /// </summary>
  public string? Manufacturer
  {
    get;
    set;
  }
  
  /// <summary>
  /// model
  /// </summary>
  public string? Model
  {
    get;
    set;
  }
  
  /// <summary>
  /// serialNo
  /// </summary>
  public string? SerialNo
  {
    get;
    set;
  }
  
  /// <summary>
  /// specificationRef
  /// </summary>
  public string? SpecificationRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// description
  /// </summary>
  public string? Description
  {
    get;
    set;
  }
  
  /// <summary>
  /// TraceFormat.
  /// </summary>
  public ITraceFormat? TraceFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// SampleRate.
  /// </summary>
  public ISampleRate? SampleRate
  {
    get;
    set;
  }
  
  /// <summary>
  /// Latency.
  /// </summary>
  public ILatency? Latency
  {
    get;
    set;
  }
  
  /// <summary>
  /// ActiveArea.
  /// </summary>
  public IActiveArea? ActiveArea
  {
    get;
    set;
  }
  
}
