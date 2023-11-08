namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a custom XML attribute which shall be located on the parent custom XML element specified via the customXml element. The uri attribute can specify the Namespace of the custom XML attribute, and the name attribute shall specify the local name of the custom XML attribute. For any set of sibling attr elements, all the pairs of Namespace and local name shall be distinct.
/// </summary>
public partial class CustomXmlAttribute: ModelElement<DXW.CustomXmlAttribute>
{
  public CustomXmlAttribute(): base(){ }
  
  public CustomXmlAttribute(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlAttribute(DXW.CustomXmlAttribute openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   uri
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
  ///   name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   val
  /// </summary>
  [DataMember]
  public String? Val
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Val);
    }
    set
    {
      _ExistingElement.Val = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
