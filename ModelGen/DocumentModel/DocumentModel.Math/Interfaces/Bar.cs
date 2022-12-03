namespace DocumentModel.Math;

/// <summary>
/// Bar.
/// </summary>
public interface Bar // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Bar Properties.
  /// </summary>
  public BarProperties? BarProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base { get ; set; }
  
}
