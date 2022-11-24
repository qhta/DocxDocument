namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definition Instance.
/// </summary>
public interface INumberingInstance // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// numId
  /// </summary>
  public Int32? NumberID { get ; set; }
  
  /// <summary>
  /// durableId
  /// </summary>
  public Int32? DurableId { get ; set; }
  
  /// <summary>
  /// AbstractNumId.
  /// </summary>
  public IAbstractNumId? AbstractNumId { get ; set; }
  
}
