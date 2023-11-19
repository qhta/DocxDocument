namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the ColorStyle Class.
/// </summary>
public partial class ColorStyle: ModelElement<DXO13DCS.ColorStyle>
{
  public ColorStyle(): base(){ }
  
  public ColorStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorStyle(DXO13DCS.ColorStyle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   meth, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Method
  {
    get => _Element?.Method;
    set => _ExistingElement.Method = value;
  }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  [DataMember]
  public DMDCS.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
