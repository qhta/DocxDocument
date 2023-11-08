namespace DocumentModel.Drawings;


/// <summary>
///   Text Paragraphs.
/// </summary>
public partial class Paragraph: ModelElement<DXD.Paragraph>
{
  public Paragraph(): base(){ }
  
  public Paragraph(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Paragraph(DXD.Paragraph openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMD.ParagraphProperties? ParagraphProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ParagraphProperties>();
      if (element != null)
        return ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.EndParagraphRunProperties? EndParagraphRunProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.EndParagraphRunProperties>();
      if (element != null)
        return EndParagraphRunPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EndParagraphRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndParagraphRunPropertiesConverter.CreateOpenXmlElement<DXD.EndParagraphRunProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
