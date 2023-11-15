namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DateAxExtension Class.
/// </summary>
public partial class DateAxExtension: ModelElement<DXDC.DateAxExtension>
{
  public DateAxExtension(): base(){ }
  
  public DateAxExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DateAxExtension(DXDC.DateAxExtension openXmlElement): base(openXmlElement) { }
  
  
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
