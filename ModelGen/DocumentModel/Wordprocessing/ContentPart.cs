namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a reference to XML content in a format not defined by ECMA-376.
/// </summary>
public partial class ContentPart: ModelElement<DXW.ContentPart>
{
  public ContentPart(): base(){ }
  
  public ContentPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContentPart(DXW.ContentPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
