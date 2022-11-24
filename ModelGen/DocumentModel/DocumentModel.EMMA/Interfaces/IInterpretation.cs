namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Interpretation Class.
/// </summary>
public interface IInterpretation // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// tokens
  /// </summary>
  public String? Tokens { get ; set; }
  
  /// <summary>
  /// process
  /// </summary>
  public String? Process { get ; set; }
  
  /// <summary>
  /// lang
  /// </summary>
  public String? Language { get ; set; }
  
  /// <summary>
  /// signal
  /// </summary>
  public String? Signal { get ; set; }
  
  /// <summary>
  /// signal-size
  /// </summary>
  public Int32? SignalSize { get ; set; }
  
  /// <summary>
  /// media-type
  /// </summary>
  public String? MediaType { get ; set; }
  
  /// <summary>
  /// confidence
  /// </summary>
  public Decimal? Confidence { get ; set; }
  
  /// <summary>
  /// source
  /// </summary>
  public String? Source { get ; set; }
  
  /// <summary>
  /// start
  /// </summary>
  public UInt16? Start { get ; set; }
  
  /// <summary>
  /// end
  /// </summary>
  public UInt16? End { get ; set; }
  
  /// <summary>
  /// time-ref-uri
  /// </summary>
  public String? TimeReference { get ; set; }
  
  /// <summary>
  /// time-ref-anchor-point
  /// </summary>
  public AnchorPointValues? TimeReferenceAnchorPoint { get ; set; }
  
  /// <summary>
  /// offset-to-start
  /// </summary>
  public Int32? OffsetToStart { get ; set; }
  
  /// <summary>
  /// duration
  /// </summary>
  public Int32? Duration { get ; set; }
  
  /// <summary>
  /// medium
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.EnumValue<MediumValues>>? Medium { get ; set; }
  
  /// <summary>
  /// mode
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.StringValue>? Mode { get ; set; }
  
  /// <summary>
  /// function
  /// </summary>
  public String? Function { get ; set; }
  
  /// <summary>
  /// verbal
  /// </summary>
  public Boolean? Verbal { get ; set; }
  
  /// <summary>
  /// cost
  /// </summary>
  public Decimal? Cost { get ; set; }
  
  /// <summary>
  /// grammar-ref
  /// </summary>
  public String? GrammarRef { get ; set; }
  
  /// <summary>
  /// endpoint-info-ref
  /// </summary>
  public String? EndpointInfoRef { get ; set; }
  
  /// <summary>
  /// model-ref
  /// </summary>
  public String? ModelRef { get ; set; }
  
  /// <summary>
  /// dialog-turn
  /// </summary>
  public String? DialogTurn { get ; set; }
  
  /// <summary>
  /// no-input
  /// </summary>
  public Boolean? NoInput { get ; set; }
  
  /// <summary>
  /// uninterpreted
  /// </summary>
  public Boolean? Uninterpreted { get ; set; }
  
}
