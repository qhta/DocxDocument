namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the HeaderFooterReferenceType Class.
/// </summary>
public partial class HeaderFooterReferenceType: ModelElement<DXW.HeaderFooterReferenceType>
{
  public HeaderFooterReferenceType(): base(){ }
  
  public HeaderFooterReferenceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeaderFooterReferenceType(DXW.HeaderFooterReferenceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
