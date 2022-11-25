namespace DocumentModel.InkML;

/// <summary>
/// Defines the Trace Class.
/// </summary>
public interface ITrace // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.InkML.TraceTypeKind? Type { get ; set; }
  
  /// <summary>
  /// continuation
  /// </summary>
  public DocumentModel.InkML.TraceContinuationKind? Continuation { get ; set; }
  
  /// <summary>
  /// priorRef
  /// </summary>
  public System.String? PriorRef { get ; set; }
  
  /// <summary>
  /// contextRef
  /// </summary>
  public System.String? ContextRef { get ; set; }
  
  /// <summary>
  /// brushRef
  /// </summary>
  public System.String? BrushRef { get ; set; }
  
  /// <summary>
  /// duration
  /// </summary>
  public System.Decimal? Duration { get ; set; }
  
  /// <summary>
  /// timeOffset
  /// </summary>
  public System.Decimal? TimeOffset { get ; set; }
  
}
