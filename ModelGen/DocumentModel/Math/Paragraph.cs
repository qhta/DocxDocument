namespace DocumentModel.Math;


/// <summary>
///   Defines the Paragraph Class.
/// </summary>
public partial class Paragraph: ModelElement<DXM.Paragraph>
{
  public Paragraph(): base(){ }
  
  public Paragraph(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Paragraph(DXM.Paragraph openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Office Math Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMM.ParagraphProperties? ParagraphProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ParagraphProperties>();
      if (element != null)
        return ParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesConverter.CreateOpenXmlElement<DXM.ParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
