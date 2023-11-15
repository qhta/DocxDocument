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
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  
  /// <summary>
  ///   Gets or sets the element name.
  /// </summary>
  [DataMember]
  public String? Element
  {
    get => _Element?.Element;
    set => _ExistingElement.Element = value;
  }
  
  
  /// <summary>
  ///   Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  [DataMember]
  public DMW.CustomXmlProperties? CustomXmlProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
