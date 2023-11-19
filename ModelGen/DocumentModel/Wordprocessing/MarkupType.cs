namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MarkupType Class.
/// </summary>
public partial class MarkupType: ModelElement<DXW.MarkupType>
{
  public MarkupType(): base(){ }
  
  public MarkupType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarkupType(DXW.MarkupType openXmlElement): base(openXmlElement) { }
  
  
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
