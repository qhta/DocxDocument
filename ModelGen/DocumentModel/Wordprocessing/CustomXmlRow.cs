namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a custom XML element around one or more inline level structures (runs, images, fields, etc.) within a paragraph. The attributes on this element shall be used to specify the name and namespace URI of the current custom XML element.
/// </summary>
public partial class CustomXmlRow: ModelElement<DXW.CustomXmlRow>
{
  public CustomXmlRow(): base(){ }
  
  public CustomXmlRow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlRow(DXW.CustomXmlRow openXmlElement): base(openXmlElement) { }
  
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
