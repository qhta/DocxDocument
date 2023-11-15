namespace DocumentModel.Drawings;


/// <summary>
///   Text Run.
/// </summary>
public partial class Run: ModelElement<DXD.Run>
{
  public Run(): base(){ }
  
  public Run(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Run(DXD.Run openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  [DataMember]
  public DMD.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType");
  }
  
  
  /// <summary>
  ///   Text String.
  /// </summary>
  [DataMember]
  public DMD.Text? Text
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
