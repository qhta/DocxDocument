namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Choose Element.
/// </summary>
public partial class Choose: ModelElement<DXDDD.Choose>
{
  public Choose(): base(){ }
  
  public Choose(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Choose(DXDDD.Choose openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  [DataMember]
  public DMDD.DiagramChooseElse? DiagramChooseElse
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
