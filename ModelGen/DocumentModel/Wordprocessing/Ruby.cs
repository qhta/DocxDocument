namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a phonetic guide at the current location in the document. A phonetic guide (often called ruby text) is a run of content with base text which appears at the normal baseline location for text in this run, with phonetic guide text displayed above it in the document. The resulting construct is called a phonetic guide as it is typically used to map words in one language to another phonetically.
/// </summary>
public partial class Ruby: ModelElement<DXW.Ruby>
{
  public Ruby(): base(){ }
  
  public Ruby(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Ruby(DXW.Ruby openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Phonetic Guide Properties.
  /// </summary>
  [DataMember]
  public DMW.RubyProperties? RubyProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Phonetic Guide Text.
  /// </summary>
  [DataMember]
  public DMW.RubyContent? RubyContent
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RubyContentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RubyContentType");
  }
  
  
  /// <summary>
  ///   Phonetic Guide Base Text.
  /// </summary>
  [DataMember]
  public DMW.RubyBase? RubyBase
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RubyContentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RubyContentType");
  }
  
}
