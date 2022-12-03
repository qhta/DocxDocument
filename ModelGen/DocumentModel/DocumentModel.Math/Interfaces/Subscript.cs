namespace DocumentModel.Math;

/// <summary>
/// Subscript Function.
/// </summary>
public interface Subscript // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Subscript Properties.
  /// </summary>
  public SubscriptProperties? SubscriptProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base { get ; set; }
  
  /// <summary>
  /// Subscript (Subscript function).
  /// </summary>
  public SubArgument? SubArgument { get ; set; }
  
}
