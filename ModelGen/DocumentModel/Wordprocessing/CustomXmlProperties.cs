namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of properties which shall be applied to the parent custom XML element.
/// </summary>
public partial class CustomXmlProperties: ModelElement<DXW.CustomXmlProperties>
{
  public CustomXmlProperties(): base(){ }
  
  public CustomXmlProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlProperties(DXW.CustomXmlProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Custom XML Element Placeholder Text.
  /// </summary>
  [DataMember]
  public DMW.CustomXmlPlaceholder? CustomXmlPlaceholder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.CustomXmlPlaceholder>();
      if (element != null)
        return CustomXmlPlaceholderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.CustomXmlPlaceholder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomXmlPlaceholderConverter.CreateOpenXmlElement<DXW.CustomXmlPlaceholder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
