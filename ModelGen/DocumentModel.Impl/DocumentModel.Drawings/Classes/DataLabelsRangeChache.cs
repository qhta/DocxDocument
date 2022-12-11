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
  
  public DataLabelsRangeChacheImpl(): base() {}
  
  public DataLabelsRangeChacheImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new UInt32? PointCount
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.PointCount{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<StringPoint>? StringPoints
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public StrDataExtensionList? StrDataExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
