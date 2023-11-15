namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the placeholder text which shall be displayed in place of this custom XML element when the contents of this custom XML markup are empty (i.e. there are no runs of text within the current custom XML element). If this custom XML element does contain run content, then this text shall not be displayed.
/// </summary>
public partial class SdtPlaceholder: ModelElement<DXW.SdtPlaceholder>
{
  public SdtPlaceholder(): base(){ }
  
  public SdtPlaceholder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtPlaceholder(DXW.SdtPlaceholder openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Part Reference.
  /// </summary>
  [DataMember]
  public DMW.DocPartReference? DocPartReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
}
