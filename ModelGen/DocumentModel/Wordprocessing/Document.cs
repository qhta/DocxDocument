namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of a main document part in a WordprocessingML document.
/// </summary>
public partial class Document: ModelElement<DXW.Document>
{
  public Document(): base(){ }
  
  public Document(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Document(DXW.Document openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Background.
  /// </summary>
  [DataMember]
  public DMW.DocumentBackground? DocumentBackground
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Body.
  /// </summary>
  [DataMember]
  public DMW.Body? Body
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BodyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BodyType");
  }
  
}
