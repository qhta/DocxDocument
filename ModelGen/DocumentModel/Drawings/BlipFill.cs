namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the type of picture fill that the picture object has. Because a picture has a picture fill already by default, it is possible to have two fills specified for a picture object. An example of this is shown below.
/// </summary>
public partial class BlipFill: ModelElement<DXD.BlipFill>
{
  public BlipFill(): base(){ }
  
  public BlipFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BlipFill(DXD.BlipFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the DPI (dots per inch) used to calculate the size of the blip. If not present or zero, the DPI in the blip is used.
  /// </summary>
  [DataMember]
  public UInt32? Dpi
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  [DataMember]
  public Boolean? RotateWithShape
  {
    get => _Element?.RotateWithShape?.Value;
    set => _ExistingElement.RotateWithShape = value;
  }
  
  
  /// <summary>
  ///   Blip.
  /// </summary>
  [DataMember]
  public DMD.Blip? Blip
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Source Rectangle.
  /// </summary>
  [DataMember]
  public DMD.SourceRectangle? SourceRectangle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.RelativeRectangleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.RelativeRectangleType");
  }
  
  [DataMember]
  public DMD.Tile? Tile
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMD.Stretch? Stretch
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
