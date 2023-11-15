namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SdtDocPartType Class.
/// </summary>
public partial class SdtDocPartType: ModelElement<DXW.SdtDocPartType>
{
  public SdtDocPartType(): base(){ }
  
  public SdtDocPartType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtDocPartType(DXW.SdtDocPartType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Part Gallery Filter.
  /// </summary>
  [DataMember]
  public DMW.DocPartGallery? DocPartGallery
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Document Part Category Filter.
  /// </summary>
  [DataMember]
  public DMW.DocPartCategory? DocPartCategory
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Built-In Document Part.
  /// </summary>
  [DataMember]
  public DMW.DocPartUnique? DocPartUnique
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
}
