namespace DocumentModel.Vml;


/// <summary>
///   Skew Transform.
/// </summary>
public partial class Skew: ModelElement<DXVO.Skew>
{
  public Skew(): base(){ }
  
  public Skew(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Skew(DXVO.Skew openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Skew ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Skew Toggle
  /// </summary>
  [DataMember]
  public Boolean? On
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Skew Offset
  /// </summary>
  [DataMember]
  public String? Offset
  {
    get => _Element?.Offset;
    set => _ExistingElement.Offset = value;
  }
  
  
  /// <summary>
  ///   Skew Origin
  /// </summary>
  [DataMember]
  public String? Origin
  {
    get => _Element?.Origin;
    set => _ExistingElement.Origin = value;
  }
  
  
  /// <summary>
  ///   Skew Perspective Matrix
  /// </summary>
  [DataMember]
  public String? Matrix
  {
    get => _Element?.Matrix;
    set => _ExistingElement.Matrix = value;
  }
  
}
