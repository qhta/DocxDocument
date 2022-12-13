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
  
  public SingleDataSourceRecordImpl(): base() {}
  
  public SingleDataSourceRecordImpl(DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// RecordIncluded.
  /// </summary>
  public Boolean? RecordIncluded
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.RecordIncluded>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.RecordIncluded>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office.Word.RecordIncluded();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// RecordHashCode.
  /// </summary>
  public Int32? RecordHashCode
  {
    get => (System.Int32?)OpenXmlElement?.RecordHashCode?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RecordHashCode != null)
        {
          if (value is not null)
            OpenXmlElement.RecordHashCode.Val = (System.Int32?)value;
          else
            OpenXmlElement.RecordHashCode = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RecordHashCode = new DocumentFormat.OpenXml.Office.Word.RecordHashCode{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
}
