namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the PrimaryItem Class.
/// </summary>
public partial class PrimaryItem: ModelElement<DXO10CUI.PrimaryItem>
{
  public PrimaryItem(): base(){ }
  
  public PrimaryItem(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrimaryItem(DXO10CUI.PrimaryItem openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   BackstageRegularButton.
  /// </summary>
  [DataMember]
  public DMCUI10.BackstageRegularButton? BackstageRegularButton
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   BackstagePrimaryMenu.
  /// </summary>
  [DataMember]
  public DMCUI10.BackstagePrimaryMenu? BackstagePrimaryMenu
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
