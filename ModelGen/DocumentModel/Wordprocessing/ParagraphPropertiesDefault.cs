namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a set of default paragraph properties for the current document. The actual paragraph properties are stored within the pPr child element of the current element.
/// </summary>
public partial class ParagraphPropertiesDefault: ModelElement<DXW.ParagraphPropertiesDefault>
{
  public ParagraphPropertiesDefault(): base(){ }
  
  public ParagraphPropertiesDefault(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphPropertiesDefault(DXW.ParagraphPropertiesDefault openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.ParagraphPropertiesBaseStyle? ParagraphPropertiesBaseStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ParagraphPropertiesBaseStyle>();
      if (element != null)
        return ParagraphPropertiesBaseStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ParagraphPropertiesBaseStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesBaseStyleConverter.CreateOpenXmlElement<DXW.ParagraphPropertiesBaseStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
