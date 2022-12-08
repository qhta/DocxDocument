namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SingleDataSourceRecord Class.
/// </summary>
public class SingleDataSourceRecordImpl: ModelElementImpl, SingleDataSourceRecord
{
  public DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// RecordIncluded.
  /// </summary>
  public Boolean? RecordIncluded
  {
    get;
    set;
  }
  
  /// <summary>
  /// RecordHashCode.
  /// </summary>
  public Int32? RecordHashCode
  {
    get;
    set;
  }
  
}
