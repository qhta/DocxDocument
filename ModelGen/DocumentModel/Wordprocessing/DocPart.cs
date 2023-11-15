namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the name of the document part that shall be displayed in the nearest ancestor structured document tag when its run contents are empty. If this element is specified, then a document part whose name element specifies a name matching the value of this element, and which belongs to the bbPlcHdr style shall be located to be used as the placeholder text for the nearest ancestor structured document tag.
/// </summary>
public partial class DocPart: ModelElement<DXW.DocPart>
{
  public DocPart(): base(){ }
  
  public DocPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPart(DXW.DocPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Glossary Document Entry Properties.
  /// </summary>
  [DataMember]
  public DMW.DocPartProperties? DocPartProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Contents of Glossary Document Entry.
  /// </summary>
  [DataMember]
  public DMW.DocPartBody? DocPartBody
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BodyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BodyType");
  }
  
}
