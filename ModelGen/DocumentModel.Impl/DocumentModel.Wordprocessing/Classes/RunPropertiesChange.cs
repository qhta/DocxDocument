namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunPropertiesChange Class.
/// </summary>
public class RunPropertiesChangeImpl: ModelElementImpl, RunPropertiesChange
{
  public DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RunPropertiesChangeImpl(): base() {}
  
  public RunPropertiesChangeImpl(DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get => (System.String?)OpenXmlElement?.Author?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Author = (System.String?)value;
    }
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get => (System.DateTime?)OpenXmlElement?.Date?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Date = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Previous Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousRunProperties? PreviousRunProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousRunProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PreviousRunPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousRunProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PreviousRunPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
