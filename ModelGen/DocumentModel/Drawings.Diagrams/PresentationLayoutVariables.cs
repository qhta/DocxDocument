namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Presentation Layout Variables.
/// </summary>
public partial class PresentationLayoutVariables: ModelElement<DXDDD.PresentationLayoutVariables>
{
  public PresentationLayoutVariables(): base(){ }
  
  public PresentationLayoutVariables(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PresentationLayoutVariables(DXDDD.PresentationLayoutVariables openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public Boolean? OrganizationChart
  {
    get => _Element?.GetBoolVal<DXDDD.OrganizationChart>();
    set => _ExistingElement.SetBoolVal<DXDDD.OrganizationChart>(value);
  }
  
  [DataMember]
  public Int32? MaxNumberOfChildren
  {
    get => _Element?.GetIntVal<Int32, DXDDD.MaxNumberOfChildren>();
    set => _ExistingElement.SetIntVal<Int32, DXDDD.MaxNumberOfChildren>(value);
  }
  
  [DataMember]
  public Int32? PreferredNumberOfChildren
  {
    get => _Element?.GetIntVal<Int32, DXDDD.PreferredNumberOfChildren>();
    set => _ExistingElement.SetIntVal<Int32, DXDDD.PreferredNumberOfChildren>(value);
  }
  
  [DataMember]
  public Boolean? BulletEnabled
  {
    get => _Element?.GetBoolVal<DXDDD.BulletEnabled>();
    set => _ExistingElement.SetBoolVal<DXDDD.BulletEnabled>(value);
  }
  
  [DataMember]
  public DMDD.DirectionKind? Direction
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMDD.HierarchyBranchStyleKind? HierarchyBranch
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMDD.AnimateOneByOneKind? AnimateOneByOne
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMDD.AnimationLevelStringKind? AnimationLevel
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMDD.ResizeHandlesStringKind? ResizeHandles
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
