namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Whole E2O Formatting.
/// </summary>
public partial class Whole: ModelElement<DXDDD.Whole>
{
  public Whole(): base(){ }
  
  public Whole(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Whole(DXDDD.Whole openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  [DataMember]
  public DMD.Outline? Outline
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.LinePropertiesType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.LinePropertiesType");
  }
  
}
