namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ValAxExtension Class.
/// </summary>
public partial class ValAxExtension: ModelElement<DXDC.ValAxExtension>
{
  public ValAxExtension(): base(){ }
  
  public ValAxExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValAxExtension(DXDC.ValAxExtension openXmlElement): base(openXmlElement) { }
  
  
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
