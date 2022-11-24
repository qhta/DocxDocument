namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Arc Class.
/// </summary>
public interface IArc // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// from
  /// </summary>
  public Int32? From { get ; set; }
  
  /// <summary>
  /// to
  /// </summary>
  public Int32? To { get ; set; }
  
  /// <summary>
  /// start
  /// </summary>
  public UInt16? Start { get ; set; }
  
  /// <summary>
  /// end
  /// </summary>
  public UInt16? End { get ; set; }
  
  /// <summary>
  /// offset-to-start
  /// </summary>
  public Int32? OffsetToStart { get ; set; }
  
  /// <summary>
  /// duration
  /// </summary>
  public Int32? Duration { get ; set; }
  
  /// <summary>
  /// confidence
  /// </summary>
  public Decimal? Confidence { get ; set; }
  
  /// <summary>
  /// cost
  /// </summary>
  public Decimal? Cost { get ; set; }
  
  /// <summary>
  /// lang
  /// </summary>
  public String? Language { get ; set; }
  
  /// <summary>
  /// medium
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.EnumValue<MediumValues>>? Medium { get ; set; }
  
  /// <summary>
  /// mode
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.StringValue>? Mode { get ; set; }
  
  /// <summary>
  /// source
  /// </summary>
  public String? Source { get ; set; }
  
}
