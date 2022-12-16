namespace DocumentModel.Wordprocessing;

/// <summary>
/// Data About Single Data Source Record.
/// </summary>
public class RecipientDataImpl: ModelElementImpl, RecipientData
{
  public DocumentFormat.OpenXml.Wordprocessing.RecipientData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RecipientData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RecipientDataImpl(): base() {}
  
  public RecipientDataImpl(DocumentFormat.OpenXml.Wordprocessing.RecipientData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Record Is Included in Mail Merge.
  /// </summary>
  public Boolean? Active
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Active>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Active>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.Active();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Index of Column Containing Unique Values for Record.
  /// </summary>
  public UInt32? ColumnIndex
  {
    get => (System.UInt32?)OpenXmlElement?.ColumnIndex?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ColumnIndex != null)
        {
          if (value is not null)
            OpenXmlElement.ColumnIndex.Val = (System.UInt32?)value;
          else
            OpenXmlElement.ColumnIndex = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ColumnIndex = new DocumentFormat.OpenXml.Wordprocessing.ColumnIndex{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Unique Value for Record.
  /// </summary>
  public DocumentModel.Base64Binary? UniqueTag
  {
    get
    {
      if (OpenXmlElement?.UniqueTag?.Val?.Value != null)
        return (DocumentModel.Base64Binary)OpenXmlElement.UniqueTag.Val.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.UniqueTag = new DocumentFormat.OpenXml.Wordprocessing.UniqueTag{ Val = value.ToString() };
        else
          OpenXmlElement.UniqueTag = null;
      }
    }
  }
  
}
