namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definition Instance.
/// </summary>
public interface INumberingInstance // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// numId
  /// </summary>
  public System.Int32? NumberID { get ; set; }
  
  /// <summary>
  /// durableId
  /// </summary>
  public System.Int32? DurableId { get ; set; }
  
  /// <summary>
  /// AbstractNumId.
  /// </summary>
  public System.Int32? AbstractNumId { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ILevelOverride>? LevelOverrides { get ; set; }
  
}
