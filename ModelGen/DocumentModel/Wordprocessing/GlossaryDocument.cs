namespace DocumentModel.Wordprocessing;


/// <summary>
///   Glossary Document Root Element.
/// </summary>
public partial class GlossaryDocument: ModelElement<DXW.GlossaryDocument>
{
  public GlossaryDocument(): base(){ }
  
  public GlossaryDocument(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GlossaryDocument(DXW.GlossaryDocument openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Background.
  /// </summary>
  [DataMember]
  public DMW.DocumentBackground? DocumentBackground
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   List of Glossary Document Entries.
  /// </summary>
  [DataMember]
  public DMW.DocParts? DocParts
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
