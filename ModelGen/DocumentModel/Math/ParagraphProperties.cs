namespace DocumentModel.Math;


/// <summary>
///   Office Math Paragraph Properties.
/// </summary>
public partial class ParagraphProperties: ModelElement<DXM.ParagraphProperties>
{
  public ParagraphProperties(): base(){ }
  
  public ParagraphProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphProperties(DXM.ParagraphProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Justification.
  /// </summary>
  [DataMember]
  public DMM.Justification? Justification
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathJustificationType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathJustificationType");
  }
  
}
