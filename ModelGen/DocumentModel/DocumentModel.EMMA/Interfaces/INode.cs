namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Node Class.
/// </summary>
public interface INode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// node-number
  /// </summary>
  public System.Int32? NodeNumber { get ; set; }
  
  /// <summary>
  /// confidence
  /// </summary>
  public System.Decimal? Confidence { get ; set; }
  
  /// <summary>
  /// cost
  /// </summary>
  public System.Decimal? Cost { get ; set; }
  
}
