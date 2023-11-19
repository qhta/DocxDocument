namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MarkupRangeType Class.
/// </summary>
public partial class MarkupRangeType: ModelElement<DXW.MarkupRangeType>
{
  public MarkupRangeType(): base(){ }
  
  public MarkupRangeType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarkupRangeType(DXW.MarkupRangeType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
