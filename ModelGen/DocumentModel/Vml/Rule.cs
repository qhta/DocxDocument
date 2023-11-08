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
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Rule Shape Reference
  /// </summary>
  [DataMember]
  public String? ShapeReference
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ShapeReference);
    }
    set
    {
      _ExistingElement.ShapeReference = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
