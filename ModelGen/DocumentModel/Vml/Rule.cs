namespace DocumentModel.Vml;


/// <summary>
///   Rule.
/// </summary>
public partial class Rule: ModelElement<DXVO.Rule>
{
  public Rule(): base(){ }
  
  public Rule(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Rule(DXVO.Rule openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rule ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Rule Shape Reference
  /// </summary>
  [DataMember]
  public String? ShapeReference
  {
    get => _Element?.ShapeReference;
    set => _ExistingElement.ShapeReference = value;
  }
  
}
