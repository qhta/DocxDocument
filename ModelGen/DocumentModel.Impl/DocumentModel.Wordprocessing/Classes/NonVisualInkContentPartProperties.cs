namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public partial class NonVisualInkContentPartPropertiesImpl: ModelElementImpl, NonVisualInkContentPartProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.NonVisualInkContentPartProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.NonVisualInkContentPartProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NonVisualInkContentPartPropertiesImpl(): base() {}
  
  public NonVisualInkContentPartPropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.NonVisualInkContentPartProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// isComment, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? IsComment
  {
    get => (System.Boolean?)OpenXmlElement?.IsComment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IsComment = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  public DocumentModel.Drawings.ContentPartLocks? ContentPartLocks
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>();
        if (item != null)
          return new DocumentModel.Drawings.ContentPartLocksImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ContentPartLocksImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.OfficeArtExtensionList2? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.OfficeArtExtensionList2Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.OfficeArtExtensionList2Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
