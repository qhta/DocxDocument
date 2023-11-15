namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Presentation Of.
/// </summary>
public partial class PresentationOf: ModelElement<DXDDD.PresentationOf>
{
  public PresentationOf(): base(){ }
  
  public PresentationOf(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PresentationOf(DXDDD.PresentationOf openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Axis
  /// </summary>
  [DataMember]
  public DM.ListOf<AxisKind>? Axis
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Data Point Type
  /// </summary>
  [DataMember]
  public DM.ListOf<ElementKind>? PointType
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Hide Last Transition
  /// </summary>
  [DataMember]
  public DM.ListOf<Boolean>? HideLastTrans
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Start
  /// </summary>
  [DataMember]
  public DM.ListOf<Int32>? Start
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Count
  /// </summary>
  [DataMember]
  public DM.ListOf<UInt32>? Count
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Step
  /// </summary>
  [DataMember]
  public DM.ListOf<Int32>? Step
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
