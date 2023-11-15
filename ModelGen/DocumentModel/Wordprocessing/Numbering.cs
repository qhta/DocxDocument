namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Definitions.
/// </summary>
public partial class Numbering: ModelElement<DXW.Numbering>
{
  public Numbering(): base(){ }
  
  public Numbering(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Numbering(DXW.Numbering openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.NumberingIdMacAtCleanup? NumberingIdMacAtCleanup
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
  }
  
}
