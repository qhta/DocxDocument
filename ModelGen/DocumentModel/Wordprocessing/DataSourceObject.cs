namespace DocumentModel.Wordprocessing;


/// <summary>
///   Office Data Source Object Settings.
/// </summary>
public partial class DataSourceObject: ModelElement<DXW.DataSourceObject>
{
  public DataSourceObject(): base(){ }
  
  public DataSourceObject(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataSourceObject(DXW.DataSourceObject openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   UDL Connection String.
  /// </summary>
  [DataMember]
  public DMW.UdlConnectionString? UdlConnectionString
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Data Source Table Name.
  /// </summary>
  [DataMember]
  public DMW.DataSourceTableName? DataSourceTableName
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   ODSO Data Source File Path.
  /// </summary>
  [DataMember]
  public DMW.SourceReference? SourceReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
  }
  
  
  /// <summary>
  ///   Column Delimiter for Data Source.
  /// </summary>
  [DataMember]
  public DMW.ColumnDelimiter? ColumnDelimiter
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.UnsignedDecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.UnsignedDecimalNumberType");
  }
  
  
  /// <summary>
  ///   ODSO Data Source Type.
  /// </summary>
  [DataMember]
  public DMW.MailMergeSourceKind? MailMergeSource
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   First Row of Data Source Contains Column Names.
  /// </summary>
  [DataMember]
  public DMW.FirstRowHeader? FirstRowHeader
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  [DataMember]
  public DMW.RecipientDataReference? RecipientDataReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
  }
  
}
