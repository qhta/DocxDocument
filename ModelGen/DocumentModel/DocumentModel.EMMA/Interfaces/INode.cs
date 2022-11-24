namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Node Class.
/// </summary>
public interface INode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// node-number
  /// </summary>
  public Int32? NodeNumber { get ; set; }
  
  /// <summary>
  /// confidence
  /// </summary>
  public Decimal? Confidence { get ; set; }
  
  /// <summary>
  /// cost
  /// </summary>
  public Decimal? Cost { get ; set; }
  
}
