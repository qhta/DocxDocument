namespace DocumentModel.InkML;

/// <summary>
/// Defines the Trace Class.
/// </summary>
public interface ITrace // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public TraceTypeValues? Type { get ; set; }
  
  /// <summary>
  /// continuation
  /// </summary>
  public TraceContinuationValues? Continuation { get ; set; }
  
  /// <summary>
  /// priorRef
  /// </summary>
  public String? PriorRef { get ; set; }
  
  /// <summary>
  /// contextRef
  /// </summary>
  public String? ContextRef { get ; set; }
  
  /// <summary>
  /// brushRef
  /// </summary>
  public String? BrushRef { get ; set; }
  
  /// <summary>
  /// duration
  /// </summary>
  public Decimal? Duration { get ; set; }
  
  /// <summary>
  /// timeOffset
  /// </summary>
  public Decimal? TimeOffset { get ; set; }
  
}
