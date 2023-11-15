namespace DocumentModel.Wordprocessing;


/// <summary>
///   Mail Merge Settings.
/// </summary>
public partial class MailMerge: ModelElement<DXW.MailMerge>
{
  public MailMerge(): base(){ }
  
  public MailMerge(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MailMerge(DXW.MailMerge openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Source Document Type.
  /// </summary>
  [DataMember]
  public DMW.MailMergeDocumentKind? MainDocumentType
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Query Contains Link to External Query File.
  /// </summary>
  [DataMember]
  public DMW.LinkToQuery? LinkToQuery
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Data Source Type.
  /// </summary>
  [DataMember]
  public DMW.MailMergeDataKind? DataType
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Data Source Connection String.
  /// </summary>
  [DataMember]
  public DMW.ConnectString? ConnectString
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Query For Data Source Records To Merge.
  /// </summary>
  [DataMember]
  public DMW.Query? Query
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Data Source File Path.
  /// </summary>
  [DataMember]
  public DMW.DataSourceReference? DataSourceReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
  }
  
  
  /// <summary>
  ///   Header Definition File Path.
  /// </summary>
  [DataMember]
  public DMW.HeaderSource? HeaderSource
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
  }
  
  
  /// <summary>
  ///   Remove Blank Lines from Merged Documents.
  /// </summary>
  [DataMember]
  public DMW.DoNotSuppressBlankLines? DoNotSuppressBlankLines
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Merged Document Destination.
  /// </summary>
  [DataMember]
  public DMW.MailMergeDestinationKind? Destination
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Column Containing E-mail Address.
  /// </summary>
  [DataMember]
  public DMW.AddressFieldName? AddressFieldName
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Merged E-mail or Fax Subject Line.
  /// </summary>
  [DataMember]
  public DMW.MailSubject? MailSubject
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Merged Document To E-Mail Attachment.
  /// </summary>
  [DataMember]
  public DMW.MailAsAttachment? MailAsAttachment
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   View Merged Data Within Document.
  /// </summary>
  [DataMember]
  public DMW.ViewMergedData? ViewMergedData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Record Currently Displayed In Merged Document.
  /// </summary>
  [DataMember]
  public DMW.ActiveRecord? ActiveRecord
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
  }
  
  
  /// <summary>
  ///   Mail Merge Error Reporting Setting.
  /// </summary>
  [DataMember]
  public DMW.CheckErrors? CheckErrors
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
  }
  
  
  /// <summary>
  ///   Office Data Source Object Settings.
  /// </summary>
  [DataMember]
  public DMW.DataSourceObject? DataSourceObject
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
