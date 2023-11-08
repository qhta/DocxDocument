namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a custom XML element around one or more inline level structures (runs, images, fields, etc.) within a paragraph. The attributes on this element shall be used to specify the name and namespace URI of the current custom XML element.
/// </summary>
public partial class CustomXmlCell: ModelElement<DXW.CustomXmlCell>
{
  public CustomXmlCell(): base(){ }
  
  public CustomXmlCell(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlCell(DXW.CustomXmlCell openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.CustomXmlProperties? CustomXmlProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.CustomXmlProperties>();
      if (element != null)
        return CustomXmlPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.CustomXmlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomXmlPropertiesConverter.CreateOpenXmlElement<DXW.CustomXmlProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
