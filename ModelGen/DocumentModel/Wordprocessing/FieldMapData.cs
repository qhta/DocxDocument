namespace DocumentModel.Wordprocessing;


/// <summary>
///   External Data Source to Merge Field Mapping.
/// </summary>
public partial class FieldMapData: ModelElement<DXW.FieldMapData>
{
  public FieldMapData(): base(){ }
  
  public FieldMapData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FieldMapData(DXW.FieldMapData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Merge Field Mapping.
  /// </summary>
  [DataMember]
  public DMW.MailMergeOdsoFieldKind? MailMergeFieldType
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Data Source Name for Column.
  /// </summary>
  [DataMember]
  public DMW.Name? Name
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Predefined Merge Field Name.
  /// </summary>
  [DataMember]
  public DMW.MappedName? MappedName
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Index of Column Being Mapped.
  /// </summary>
  [DataMember]
  public DMW.ColumnIndex? ColumnIndex
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.UnsignedDecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.UnsignedDecimalNumberType");
  }
  
  
  /// <summary>
  ///   Merge Field Name Language ID.
  /// </summary>
  [DataMember]
  public String? LanguageId
  {
    get => _Element?.GetStringVal<DXW.LanguageId>();
    set => _ExistingElement.SetStringVal<DXW.LanguageId>(value);
  }
  
  
  /// <summary>
  ///   Use Country/Region-Based Address Field Ordering.
  /// </summary>
  [DataMember]
  public DMW.DynamicAddress? DynamicAddress
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
}
