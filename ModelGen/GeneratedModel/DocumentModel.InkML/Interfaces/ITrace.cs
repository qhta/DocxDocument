namespace DocumentModel.InkML;

/// <summary>
/// Defines the Trace Class.
/// </summary>
public interface ITrace // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public TraceType? Type { get ; set; }
  
  /// <summary>
  /// continuation
  /// </summary>
  public TraceContinuation? Continuation { get ; set; }
  
  /// <summary>
  /// priorRef
  /// </summary>
  public string? PriorRef { get ; set; }
  
  /// <summary>
  /// contextRef
  /// </summary>
  public string? ContextRef { get ; set; }
  
  /// <summary>
  /// brushRef
  /// </summary>
  public string? BrushRef { get ; set; }
  
  /// <summary>
  /// duration
  /// </summary>
  public decimal? Duration { get ; set; }
  
  /// <summary>
  /// timeOffset
  /// </summary>
  public decimal? TimeOffset { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
