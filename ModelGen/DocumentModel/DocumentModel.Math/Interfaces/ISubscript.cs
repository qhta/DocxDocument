namespace DocumentModel.Math;

/// <summary>
/// Subscript Function.
/// </summary>
public interface ISubscript // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Subscript Properties.
  /// </summary>
  public DocumentModel.Math.ISubscriptProperties? SubscriptProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? Base { get ; set; }
  
  /// <summary>
  /// Subscript (Subscript function).
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? SubArgument { get ; set; }
  
}
