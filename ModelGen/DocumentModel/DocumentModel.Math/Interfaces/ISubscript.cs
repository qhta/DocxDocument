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
  public DocumentModel.Math.IBase? Base { get ; set; }
  
  /// <summary>
  /// Subscript (Subscript function).
  /// </summary>
  public DocumentModel.Math.ISubArgument? SubArgument { get ; set; }
  
}
