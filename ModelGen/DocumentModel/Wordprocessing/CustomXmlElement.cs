namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines CustomXmlElement - the base class for the customXml elements.
/// </summary>
public partial class CustomXmlElement: ModelElement<DXW.CustomXmlElement>
{
  public CustomXmlElement(): base(){ }
  
  public CustomXmlElement(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlElement(DXW.CustomXmlElement openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the custom XML Markup Namespace.
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Gets or sets the element name.
  /// </summary>
  [DataMember]
  public String? Element
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Element);
    }
    set
    {
      _ExistingElement.Element = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
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
