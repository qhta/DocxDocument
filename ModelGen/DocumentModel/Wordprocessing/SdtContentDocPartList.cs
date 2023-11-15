namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be of a document part gallery type.
/// </summary>
public partial class SdtContentDocPartList: ModelElement<DXW.SdtContentDocPartList>
{
  public SdtContentDocPartList(): base(){ }
  
  public SdtContentDocPartList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentDocPartList(DXW.SdtContentDocPartList openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.DocPartGallery? DocPartGallery
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  [DataMember]
  public DMW.DocPartCategory? DocPartCategory
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  [DataMember]
  public DMW.DocPartUnique? DocPartUnique
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
}
