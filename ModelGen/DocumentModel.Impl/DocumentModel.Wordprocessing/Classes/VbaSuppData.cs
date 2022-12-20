namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VbaSuppData Class.
/// </summary>
public partial class VbaSuppDataImpl: ModelElementImpl, VbaSuppData
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Word.VbaSuppData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.VbaSuppData?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public VbaSuppDataImpl(): base() {}
  
  public VbaSuppDataImpl(DocumentFormat.OpenXml.Office.Word.VbaSuppData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// DocEvents.
  /// </summary>
  public DocumentModel.Wordprocessing.DocEvents? DocEvents
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.DocEvents>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DocEventsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.DocEvents>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DocEventsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Mcds.
  /// </summary>
  public DocumentModel.Wordprocessing.Mcds? Mcds
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Mcds>();
        if (item != null)
          return new DocumentModel.Wordprocessing.McdsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Mcds>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.McdsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
