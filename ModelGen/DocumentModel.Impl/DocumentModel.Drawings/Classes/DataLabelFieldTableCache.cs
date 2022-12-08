namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabelFieldTableCache Class.
/// </summary>
public class DataLabelFieldTableCacheImpl: DocumentModel.Drawings.StringDataType2Impl, DataLabelFieldTableCache
{
  public new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override UInt32? PointCount
  {
    get;
    set;
  }
  
  public Collection<StringPoint>? StringPoints
  {
    get;
    set;
  }
  
  public StrDataExtensionList? StrDataExtensionList
  {
    get;
    set;
  }
  
}
