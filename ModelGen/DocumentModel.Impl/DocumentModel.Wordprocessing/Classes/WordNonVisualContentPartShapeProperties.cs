namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the WordNonVisualContentPartShapeProperties Class.
/// </summary>
public partial class WordNonVisualContentPartShapePropertiesImpl: ModelElementImpl, WordNonVisualContentPartShapeProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.WordNonVisualContentPartShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.WordNonVisualContentPartShapeProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WordNonVisualContentPartShapePropertiesImpl(): base() {}
  
  public WordNonVisualContentPartShapePropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.WordNonVisualContentPartShapeProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NonVisualDrawingProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.NonVisualDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NonVisualDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.NonVisualDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.NonVisualInkContentPartProperties? NonVisualInkContentPartProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NonVisualInkContentPartProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.NonVisualInkContentPartPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NonVisualInkContentPartProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.NonVisualInkContentPartPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
