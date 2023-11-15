namespace DocumentModel.Math;


/// <summary>
///   Group-Character Properties.
/// </summary>
public partial class GroupCharProperties: ModelElement<DXM.GroupCharProperties>
{
  public GroupCharProperties(): base(){ }
  
  public GroupCharProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupCharProperties(DXM.GroupCharProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Group Character (Grouping Character).
  /// </summary>
  [DataMember]
  public DMM.AccentChar? AccentChar
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
  }
  
  
  /// <summary>
  ///   Position (Group Character).
  /// </summary>
  [DataMember]
  public DMM.Position? Position
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TopBottomType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TopBottomType");
  }
  
  
  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  [DataMember]
  public DMM.VerticalJustification? VerticalJustification
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TopBottomType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TopBottomType");
  }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
