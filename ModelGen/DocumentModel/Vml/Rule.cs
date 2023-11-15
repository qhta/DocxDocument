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
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
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
