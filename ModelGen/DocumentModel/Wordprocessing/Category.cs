namespace DocumentModel.Wordprocessing;


/// <summary>
///   Entry Categorization.
/// </summary>
public partial class Category: ModelElement<DXW.Category>
{
  public Category(): base(){ }
  
  public Category(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Category(DXW.Category openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Category Associated With Entry.
  /// </summary>
  [DataMember]
  public DMW.Name? Name
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Gallery Associated With Entry.
  /// </summary>
  [DataMember]
  public DMW.DocPartGalleryKind? Gallery
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
