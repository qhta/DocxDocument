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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
}
