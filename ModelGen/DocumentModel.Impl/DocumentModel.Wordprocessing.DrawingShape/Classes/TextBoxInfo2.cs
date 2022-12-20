namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
/// Defines the TextBoxInfo2 Class.
/// </summary>
public partial class TextBoxInfo2Impl: ModelElementImpl, TextBoxInfo2
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.DrawingShape.TextBoxInfo2? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.DrawingShape.TextBoxInfo2?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TextBoxInfo2Impl(): base() {}
  
  public TextBoxInfo2Impl(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.TextBoxInfo2 openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt16? Id
  {
    get => (System.UInt16?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.UInt16?)value;
    }
  }
  
  /// <summary>
  /// TextBoxContent.
  /// </summary>
  public DocumentModel.Wordprocessing.TextBoxContent? TextBoxContent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TextBoxContentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TextBoxContentImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingShape.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingShape.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingShape.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
