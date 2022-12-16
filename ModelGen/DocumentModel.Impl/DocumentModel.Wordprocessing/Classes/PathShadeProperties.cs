namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PathShadeProperties Class.
/// </summary>
public class PathShadePropertiesImpl: ModelElementImpl, PathShadeProperties
{
  public DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PathShadePropertiesImpl(): base() {}
  
  public PathShadePropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// path, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PathShadeKind? Path
  {
    get => (DocumentModel.Wordprocessing.PathShadeKind?)OpenXmlElement?.Path?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Path = (DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues?)value;
    }
  }
  
  /// <summary>
  /// FillToRectangle.
  /// </summary>
  public DocumentModel.Wordprocessing.FillToRectangle? FillToRectangle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillToRectangle>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FillToRectangleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillToRectangle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FillToRectangleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
