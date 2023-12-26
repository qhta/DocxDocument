namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Part Titles.
/// </summary>
public partial class TitlesOfParts: ModelElement<DXEP.TitlesOfParts>
{
  public TitlesOfParts(): base(){ }
  
  public TitlesOfParts(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TitlesOfParts(DXEP.TitlesOfParts openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Vector.
  /// </summary>
  [DataMember]
  public DMVT.VTVector? VTVector
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
