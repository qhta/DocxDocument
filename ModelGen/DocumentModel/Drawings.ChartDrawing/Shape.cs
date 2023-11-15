namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Shape Definition.
/// </summary>
public partial class Shape: ModelElement<DXDCD.Shape>
{
  public Shape(): base(){ }
  
  public Shape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shape(DXDCD.Shape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  [DataMember]
  public String? Macro
  {
    get => _Element?.Macro;
    set => _ExistingElement.Macro = value;
  }
  
  
  /// <summary>
  ///   Text Link
  /// </summary>
  [DataMember]
  public String? TextLink
  {
    get => _Element?.TextLink;
    set => _ExistingElement.TextLink = value;
  }
  
  
  /// <summary>
  ///   Lock Text
  /// </summary>
  [DataMember]
  public Boolean? LockText
  {
    get => _Element?.LockText?.Value;
    set => _ExistingElement.LockText = value;
  }
  
  
  /// <summary>
  ///   Publish to Server
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get => _Element?.Published?.Value;
    set => _ExistingElement.Published = value;
  }
  
  
  /// <summary>
  ///   Non-Visual Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualShapeProperties? NonVisualShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Shape Style.
  /// </summary>
  [DataMember]
  public DMDCD.Style? Style
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Shape Text Body.
  /// </summary>
  [DataMember]
  public DMDCD.TextBody? TextBody
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
