namespace DocumentModel.Vml;


/// <summary>
///   Ink.
/// </summary>
public partial class Ink: ModelElement<DXVO.Ink>
{
  public Ink(): base(){ }
  
  public Ink(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Ink(DXVO.Ink openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Ink Data
  /// </summary>
  [DataMember]
  public DM.Base64Binary? InkData
  {
    get => Base64BinaryConverter.GetValue(_Element?.InkData);
    set => _ExistingElement.InkData = Base64BinaryConverter.CreateBase64BinaryValue(value);
  }
  
  
  /// <summary>
  ///   Annotation Flag
  /// </summary>
  [DataMember]
  public Boolean? AnnotationFlag
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
}
