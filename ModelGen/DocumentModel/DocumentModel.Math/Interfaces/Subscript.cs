namespace DocumentModel.Math;

/// <summary>
/// Subscript Function.
/// </summary>
public partial interface Subscript
{
  /// <summary>
  /// Subscript Properties.
  /// </summary>
  public DocumentModel.Math.SubscriptProperties? SubscriptProperties { get; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get; set; }
  
  /// <summary>
  /// Subscript (Subscript function).
  /// </summary>
  public DocumentModel.Math.SubArgument? SubArgument { get; set; }
  
}
