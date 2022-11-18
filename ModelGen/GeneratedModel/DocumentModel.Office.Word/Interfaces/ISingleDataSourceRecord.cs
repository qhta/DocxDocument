namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the SingleDataSourceRecord Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Word.IRecordHashCode))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IRecordIncluded))]
public interface ISingleDataSourceRecord // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// RecordIncluded.
  /// </summary>
  public IRecordIncluded? RecordIncluded { get ; set; }
  
  /// <summary>
  /// RecordHashCode.
  /// </summary>
  public IRecordHashCode? RecordHashCode { get ; set; }
  
}
