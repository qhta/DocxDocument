namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public partial class DocPartPropertiesImpl: ModelElementImpl, DocPartProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocPartProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DocPartPropertiesImpl(): base() {}
  
  public DocPartPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Entry Name.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartName? DocPartName
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartName>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DocPartNameImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartName>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DocPartNameImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  public String? StyleId
  {
    get => (System.String?)OpenXmlElement?.StyleId?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.StyleId != null)
        {
          if (value is not null)
            OpenXmlElement.StyleId.Val = (System.String?)value;
          else
            OpenXmlElement.StyleId = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.StyleId = new DocumentFormat.OpenXml.Wordprocessing.StyleId{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  public DocumentModel.Wordprocessing.Category? Category
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Category>();
        if (item != null)
          return new DocumentModel.Wordprocessing.CategoryImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Category>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.CategoryImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartTypes? DocPartTypes
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartTypes>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DocPartTypesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartTypes>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DocPartTypesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  public DocumentModel.Wordprocessing.Behaviors? Behaviors
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behaviors>();
        if (item != null)
          return new DocumentModel.Wordprocessing.BehaviorsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behaviors>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.BehaviorsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  public String? Description
  {
    get => (System.String?)OpenXmlElement?.Description?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Description != null)
        {
          if (value is not null)
            OpenXmlElement.Description.Val = (System.String?)value;
          else
            OpenXmlElement.Description = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Description = new DocumentFormat.OpenXml.Wordprocessing.Description{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  public String? DocPartId
  {
    get => (System.String?)OpenXmlElement?.DocPartId?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DocPartId != null)
        {
          if (value is not null)
            OpenXmlElement.DocPartId.Val = (System.String?)value;
          else
            OpenXmlElement.DocPartId = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DocPartId = new DocumentFormat.OpenXml.Wordprocessing.DocPartId{ Val = (System.String?)value };
        }
      }
    }
  }
  
}
