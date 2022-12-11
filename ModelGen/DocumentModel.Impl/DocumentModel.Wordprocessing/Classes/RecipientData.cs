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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Active>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.Active{ Val = (System.Boolean?)value };
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColumnIndex>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColumnIndex>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.ColumnIndex{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Unique Value for Record.
  /// </summary>
  public Base64BinaryValue? UniqueTag
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
