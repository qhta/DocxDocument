namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VbaSuppData Class.
/// </summary>
public partial class VbaSuppDataImpl: ModelElementImpl, VbaSuppData
{
  public DocumentFormat.OpenXml.Office.Word.VbaSuppData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.VbaSuppData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  
  /// <summary>
  /// Gets the VbaDataPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.VbaDataPart? VbaDataPart
  {
    get
    {
      if (OpenXmlElement?.VbaDataPart != null)
        return new DocumentModel.Packaging.VbaDataPartImpl(OpenXmlElement.VbaDataPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.VbaDataPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
}
