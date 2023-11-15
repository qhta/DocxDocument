namespace DocumentModel.Drawings;


/// <summary>
///   Text Line Break.
/// </summary>
public partial class Break: ModelElement<DXD.Break>
{
  public Break(): base(){ }
  
  public Break(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Break(DXD.Break openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Run Properties.
  /// </summary>
  [DataMember]
  public DMD.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType");
  }
  
}
