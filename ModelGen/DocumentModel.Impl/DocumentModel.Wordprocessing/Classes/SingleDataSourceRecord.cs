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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.RecordIncluded>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office.Word.RecordIncluded{ Val = (System.Boolean?)value };
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.RecordHashCode>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.RecordHashCode>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office.Word.RecordHashCode{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
