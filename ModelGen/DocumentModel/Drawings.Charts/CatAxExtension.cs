namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the CatAxExtension Class.
/// </summary>
public partial class CatAxExtension: ModelElement<DXDC.CatAxExtension>
{
  public CatAxExtension(): base(){ }
  
  public CatAxExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CatAxExtension(DXDC.CatAxExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  [DataMember]
  public DMDC13.NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
