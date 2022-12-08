namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabelsRangeChache Class.
/// </summary>
public class DataLabelsRangeChacheImpl: DocumentModel.Drawings.StringDataType2Impl, DataLabelsRangeChache
{
  public new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache?)_OpenXmlElement;
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
