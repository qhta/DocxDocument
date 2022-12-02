namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SingleDataSourceRecord Class.
/// </summary>
public interface ISingleDataSourceRecord // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RecordIncluded.
  /// </summary>
  public Boolean? RecordIncluded { get ; set; }
  
  /// <summary>
  /// RecordHashCode.
  /// </summary>
  public Int32? RecordHashCode { get ; set; }
  
}
