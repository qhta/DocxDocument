namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Group Class.
/// </summary>
public interface IGroup // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// tokens
  /// </summary>
  public System.String? Tokens { get ; set; }
  
  /// <summary>
  /// process
  /// </summary>
  public System.String? Process { get ; set; }
  
  /// <summary>
  /// lang
  /// </summary>
  public System.String? Language { get ; set; }
  
  /// <summary>
  /// signal
  /// </summary>
  public System.String? Signal { get ; set; }
  
  /// <summary>
  /// signal-size
  /// </summary>
  public System.Int32? SignalSize { get ; set; }
  
  /// <summary>
  /// media-type
  /// </summary>
  public System.String? MediaType { get ; set; }
  
  /// <summary>
  /// confidence
  /// </summary>
  public System.Decimal? Confidence { get ; set; }
  
  /// <summary>
  /// source
  /// </summary>
  public System.String? Source { get ; set; }
  
  /// <summary>
  /// start
  /// </summary>
  public System.UInt16? Start { get ; set; }
  
  /// <summary>
  /// end
  /// </summary>
  public System.UInt16? End { get ; set; }
  
  /// <summary>
  /// time-ref-uri
  /// </summary>
  public System.String? TimeReference { get ; set; }
  
  /// <summary>
  /// time-ref-anchor-point
  /// </summary>
  public DocumentModel.EMMA.AnchorPointKind? TimeReferenceAnchorPoint { get ; set; }
  
  /// <summary>
  /// offset-to-start
  /// </summary>
  public System.Int32? OffsetToStart { get ; set; }
  
  /// <summary>
  /// duration
  /// </summary>
  public System.Int32? Duration { get ; set; }
  
  /// <summary>
  /// medium
  /// </summary>
  public System.Collections.Generic.List<DocumentModel.EMMA.MediumKind>? Medium { get ; set; }
  
  /// <summary>
  /// mode
  /// </summary>
  public System.Collections.Generic.List<System.String>? Mode { get ; set; }
  
  /// <summary>
  /// function
  /// </summary>
  public System.String? Function { get ; set; }
  
  /// <summary>
  /// verbal
  /// </summary>
  public System.Boolean? Verbal { get ; set; }
  
  /// <summary>
  /// cost
  /// </summary>
  public System.Decimal? Cost { get ; set; }
  
  /// <summary>
  /// grammar-ref
  /// </summary>
  public System.String? GrammarRef { get ; set; }
  
  /// <summary>
  /// endpoint-info-ref
  /// </summary>
  public System.String? EndpointInfoRef { get ; set; }
  
  /// <summary>
  /// model-ref
  /// </summary>
  public System.String? ModelRef { get ; set; }
  
  /// <summary>
  /// dialog-turn
  /// </summary>
  public System.String? DialogTurn { get ; set; }
  
}
