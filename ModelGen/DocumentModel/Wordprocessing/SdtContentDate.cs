namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be a date picker when displayed in the document.
/// </summary>
public partial class SdtContentDate: ModelElement<DXW.SdtContentDate>
{
  public SdtContentDate(): base(){ }
  
  public SdtContentDate(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentDate(DXW.SdtContentDate openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Last Known Date in XML Schema DateTime Format
  /// </summary>
  [DataMember]
  public DateTime? FullDate
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Date Display Mask.
  /// </summary>
  [DataMember]
  public DMW.DateFormat? DateFormat
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Date Picker Language ID.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? LanguageId
  {
    get => _Element?.GetHexIntVal<DXW.LanguageId>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Custom XML Data Date Storage Format.
  /// </summary>
  [DataMember]
  public DMW.DateFormatKind? SdtDateMappingType
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Date Picker Calendar Type.
  /// </summary>
  [DataMember]
  public DMW.CalendarKind? Calendar
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
