namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StrDataExtension Class.
/// </summary>
public partial class StrDataExtension: ModelElement<DXDC.StrDataExtension>
{
  public StrDataExtension(): base(){ }
  
  public StrDataExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StrDataExtension(DXDC.StrDataExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.AutoGeneneratedCategories? AutoGeneneratedCategories
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.BooleanType");
  }
  
}
