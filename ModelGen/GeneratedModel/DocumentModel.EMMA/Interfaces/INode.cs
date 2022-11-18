namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Node Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.EMMA.IInfo))]
public interface INode // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// node-number
  /// </summary>
  public int? NodeNumber { get ; set; }
  
  /// <summary>
  /// confidence
  /// </summary>
  public decimal? Confidence { get ; set; }
  
  /// <summary>
  /// cost
  /// </summary>
  public decimal? Cost { get ; set; }
  
}
