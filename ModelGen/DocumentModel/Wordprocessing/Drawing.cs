namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that a DrawingML object is located at this position in the run’s contents. The layout properties of this DrawingML object are specified using the WordprocessingML Drawing syntax (§20.4).
/// </summary>
public partial class Drawing: ModelElement<DXW.Drawing>
{
  public Drawing(): base(){ }
  
  public Drawing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Drawing(DXW.Drawing openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Drawing Element Anchor.
  /// </summary>
  [DataMember]
  public DMDW.Anchor? Anchor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Inline Drawing Object.
  /// </summary>
  [DataMember]
  public DMDW.Inline? Inline
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
