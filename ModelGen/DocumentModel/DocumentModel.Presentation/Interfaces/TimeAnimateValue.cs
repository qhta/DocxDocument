namespace DocumentModel.Presentation;

/// <summary>
/// Time Animate Value.
/// </summary>
public interface TimeAnimateValue // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Time
  /// </summary>
  public String? Time { get ; set; }
  
  /// <summary>
  /// Formula
  /// </summary>
  public String? Fomula { get ; set; }
  
  /// <summary>
  /// Value.
  /// </summary>
  public VariantValue? VariantValue { get ; set; }
  
}
