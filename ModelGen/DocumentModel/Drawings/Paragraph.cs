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
      return _Element?.GetObject<DMD.ParagraphProperties,DXD.ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ParagraphProperties,DXD.ParagraphProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.EndParagraphRunProperties? EndParagraphRunProperties
  {
    get
    {
      return _Element?.GetObject<DMD.EndParagraphRunProperties,DXD.EndParagraphRunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EndParagraphRunProperties,DXD.EndParagraphRunProperties>(value);
    }
  }
  
}
