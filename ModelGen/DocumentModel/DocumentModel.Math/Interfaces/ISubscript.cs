namespace DocumentModel.Math;

/// <summary>
/// Subscript Function.
/// </summary>
public interface ISubscript // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Subscript Properties.
  /// </summary>
  public ISubscriptProperties? SubscriptProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
  /// <summary>
  /// Subscript (Subscript function).
  /// </summary>
  public ISubArgument? SubArgument { get ; set; }
  
}
