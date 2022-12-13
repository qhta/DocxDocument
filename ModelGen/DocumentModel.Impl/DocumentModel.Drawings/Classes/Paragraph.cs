namespace DocumentModel.Drawings;

/// <summary>
/// Text Paragraphs.
/// </summary>
public class ParagraphImpl: ModelElementImpl, Paragraph
{
  public DocumentFormat.OpenXml.Drawing.Paragraph? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Paragraph?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ParagraphImpl(): base() {}
  
  public ParagraphImpl(DocumentFormat.OpenXml.Drawing.Paragraph openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawings.ParagraphProperties? ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Run? Run
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Break? Break
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Field? Field
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Boolean? TextMath
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.TextMath>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.TextMath>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.TextMath();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.EndParagraphRunProperties? EndParagraphRunProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
