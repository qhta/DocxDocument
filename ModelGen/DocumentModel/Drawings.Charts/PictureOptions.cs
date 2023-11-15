namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PictureOptions Class.
/// </summary>
public partial class PictureOptions: ModelElement<DXDC.PictureOptions>
{
  public PictureOptions(): base(){ }
  
  public PictureOptions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PictureOptions(DXDC.PictureOptions openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Apply To Front.
  /// </summary>
  [DataMember]
  public DMDC.ApplyToFront? ApplyToFront
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Apply To Sides.
  /// </summary>
  [DataMember]
  public DMDC.ApplyToSides? ApplyToSides
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Apply to End.
  /// </summary>
  [DataMember]
  public DMDC.ApplyToEnd? ApplyToEnd
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Picture Format.
  /// </summary>
  [DataMember]
  public DMDC.PictureFormatKind? PictureFormat
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Picture Stack Unit.
  /// </summary>
  [DataMember]
  public Double? PictureStackUnit
  {
    get => _Element?.GetIntVal<Double, DXDC.PictureStackUnit>();
    set => _ExistingElement.SetIntVal<Double, DXDC.PictureStackUnit>(value);
  }
  
}
