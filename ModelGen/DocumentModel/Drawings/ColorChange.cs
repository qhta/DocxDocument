namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a Color Change Effect. Instances of clrFrom are replaced with instances of clrTo.
/// </summary>
public partial class ColorChange: ModelElement<DXD.ColorChange>
{
  public ColorChange(): base(){ }
  
  public ColorChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorChange(DXD.ColorChange openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies whether alpha values are considered for the effect. Effect alpha values are considered if useA is true, else they are ignored.
  /// </summary>
  [DataMember]
  public Boolean? UseAlpha
  {
    get => _Element?.UseAlpha?.Value;
    set => _ExistingElement.UseAlpha = value;
  }
  
  
  /// <summary>
  ///   Change Color From.
  /// </summary>
  [DataMember]
  public DMD.ColorFrom? ColorFrom
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
  }
  
  
  /// <summary>
  ///   Change Color To.
  /// </summary>
  [DataMember]
  public DMD.ColorTo? ColorTo
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
  }
  
}
