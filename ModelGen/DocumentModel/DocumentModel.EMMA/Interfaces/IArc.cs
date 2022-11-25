namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Arc Class.
/// </summary>
public interface IArc // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// from
  /// </summary>
  public System.Int32? From { get ; set; }
  
  /// <summary>
  /// to
  /// </summary>
  public System.Int32? To { get ; set; }
  
  /// <summary>
  /// start
  /// </summary>
  public System.UInt16? Start { get ; set; }
  
  /// <summary>
  /// end
  /// </summary>
  public System.UInt16? End { get ; set; }
  
  /// <summary>
  /// offset-to-start
  /// </summary>
  public System.Int32? OffsetToStart { get ; set; }
  
  /// <summary>
  /// duration
  /// </summary>
  public System.Int32? Duration { get ; set; }
  
  /// <summary>
  /// confidence
  /// </summary>
  public System.Decimal? Confidence { get ; set; }
  
  /// <summary>
  /// cost
  /// </summary>
  public System.Decimal? Cost { get ; set; }
  
  /// <summary>
  /// lang
  /// </summary>
  public System.String? Language { get ; set; }
  
  /// <summary>
  /// medium
  /// </summary>
  public System.Collections.Generic.List<DocumentModel.EMMA.MediumKind>? Medium { get ; set; }
  
  /// <summary>
  /// mode
  /// </summary>
  public System.Collections.Generic.List<System.String>? Mode { get ; set; }
  
  /// <summary>
  /// source
  /// </summary>
  public System.String? Source { get ; set; }
  
}
