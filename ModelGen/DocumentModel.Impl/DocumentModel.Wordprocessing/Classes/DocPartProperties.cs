namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public class DocPartPropertiesImpl: ModelElementImpl, DocPartProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocPartProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartTypes? DocPartTypes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  public DocumentModel.Wordprocessing.Behaviors? Behaviors
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
