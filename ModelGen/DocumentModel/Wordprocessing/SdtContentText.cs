namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SdtContentText Class.
/// </summary>
public partial class SdtContentText: ModelElement<DXW.SdtContentText>
{
  public SdtContentText(): base(){ }
  
  public SdtContentText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentText(DXW.SdtContentText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Allow Soft Line Breaks
  /// </summary>
  [DataMember]
  public Boolean? MultiLine
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
}
