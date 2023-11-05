namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies a group of additional settings for the mail merge information 
/// which comprise an extension to the standard settings stored with a mail merge which performs two functions:
/// <list type="bullet">
///   <item>
///      First, it provides additional information about the mail merge data source, 
///      specifically: information about how to map the columns in the data source to MERGEFIELD fields 
///      and information about records which shall be included and excluded when creating merged documents, 
///      and column delimiters used in text data sources. 
///      This information can be used regardless of the value of the DataType element when it is present.
///   </item>
///   <item>
///      Second, it provides an alternate set of connection information which should be used when the DataType element 
///      specifies a value of native. This alternate connection string provides additional connection information for applications 
///      which choose to support the ODSO connection string syntax. If the DataType element 
///      specifies that the data type of the current mail merge is not native, 
///      then the second group of settings specified within this element shall be ignored in favor of their non-ODSO equivalents.
///   </item>
/// </list>
/// </summary>
[DataContract]
public partial class DataSourceObject : IOpenXmlElementMappedObject
{
  public DataSourceObject()
  {
    _Element = new DXW.DataSourceObject();
  }

  public DataSourceObject(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.DataSourceObject)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public DataSourceObject(DXW.DataSourceObject openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.DataSourceObject _Element { get; private set; }

  /// <summary>
  /// This element specifies the type of external data source to be connected to 
  /// via as part of the ODSO connection information for this mail merge.
  /// This setting is purely a suggestion of the data source type which is being used for this mail merge, 
  /// and can be ignored in favor of an alternative mechanism if one is present.
  /// </summary>
  [DataMember]
  public DXW.MailMergeSourceValues? MailMergeSource
  {
    get => _Element?.GetEnumVal<DXW.MailMergeSourceValues, DXW.MailMergeSource>();
    set => _Element.SetEnumVal<DXW.MailMergeSourceValues, DXW.MailMergeSource>(value);
  }

  /// <summary>
  /// This element specifies what the result which shall be generated when a mail merge is carried out on a given WordprocessingML source document. 
  /// In other words, this element is used to specify what is to be done with the merged documents that result from populating the fields 
  /// within a given merged WordprocessingML document with data from the specified external data source.
  /// <para>
  ///   If this element is omitted, then the default destination of merged documents shall be assumed to be of type newDocument.
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.FieldMapData? FieldMapData
  {
    get => _Element?.GetObject<DMW.FieldMapData, DXW.FieldMapData>();
    set => _Element.SetObject<DMW.FieldMapData, DXW.FieldMapData>(value);
  }

  /// <summary>
  /// This element specifies that a hosting application shall treat the first row of data in the specified external data source 
  /// as a header row containing the names of each column in the data source, rather than data to populate mapped fields 
  /// in a merged document. When present, this information shall not change the indices specified in the recipientData elements, 
  /// but shall indicate that the first row is not part of the mail merge when it is performed.
  /// </summary>
  [DataMember]
  public bool? FirstRowHeader
  {
    get => _Element?.GetBoolVal<DXW.FirstRowHeader>();
    set => _Element.SetBoolVal<DXW.FirstRowHeader>(value);
  }

  /// <summary>
  /// This element specifies the relationship whose target is the location of the external data source to be connected 
  /// to a given WordprocessingML document to perform the mail merge (for a source document) or to find the associated field data 
  /// (for a merged document) when the merge type, specified using the dataType element, is set to native.
  /// If this element is omitted, then no file location is specified for the data source for the current mail merge. 
  /// If no relationship exists with the given relationship ID, or this relationship is not of the Mail Merge Data Source relationship type, 
  /// then this document shall be considered non-conformant.
  /// <para>
  /// The data source location is only used under the following conditions:
  /// </para>
  /// <list type="bullet">
  ///   <item>
  ///    The dataType element (§17.14.10) is set to native
  ///   </item>
  ///    The current application is able to use the information contained in the odso element (§17.14.25) to access the data source
  ///   <item>
  ///   </item>
  /// </list>
  /// <para>
  /// [Guidance: In this case, using the data source file path in the src element provides an equal or greater amount of information 
  /// for the mail merge data source for clients which can consume it. end guidance]
  /// </para>
  /// </summary>
  [DataMember]
  public Reference? SourceReference
  {
    get => _Element?.GetRefId<DXW.SourceReference>();
    set => _Element.SetRefId<DXW.SourceReference>(value?.ToString());
  }

  /// <summary>
  /// This element shall specify a reference to the part which contains data about whether the set of records 
  /// in the associated data source have been explicitly included or excluded from the specified mail merge. 
  /// Only those records which must not be used to generate merged WordprocessingML documents shall be stored within the referenced part, 
  /// as all records shall be merged by default as part of the mail merge operation. 
  /// [Guidance: Applications can choose to store only those records which are excluded for efficiency, 
  /// or a list of all records in order to determine which set of records were added/removed between mail merge operations. end guidance]
  /// <para>
  /// [Rationale: When defining a mail merge, it is possible that a user wishes to connect to a specified data source, but specify only a subset of the records returned by the query specified by the query element (§17.14.26) which must be merged as part of the mail merge operation. This element allows applications to utilize a separate part to store this information, either the shared part defined by /IEC 29500, or an application-defined part as needed. end rationale]
  /// </para>
  /// <para>
  /// If the relationship type of the relationship specified by this element is not http://schemas.openxmlformats.org/officeDocument/2006/mailMergeRecipientData, is not present, or does not have a TargetMode attribute value of Internal, then the document shall be considered non-conformant. If an application cannot process external content of the content type specified by the targeted part, then it can be ignored.
  /// </para>
  /// <para>
  /// IEC 29500 defines one shared mechanism for storing this data: using the Mail Merge Recipient Data part. This mechanism shall be used if the associated data source has a column which can be used as the unique key. However, when using data sources which do not have a unique key, applications can store their own part (of an application-defined content type) using this relationship.
  /// </para>
  /// </summary>
  [DataMember]
  public Reference? RecipientDataReference
  {
    get => _Element?.GetRefId<DXW.RecipientDataReference>();
    set => _Element.SetRefId<DXW.RecipientDataReference>(value?.ToString());
  }

  /// <summary>
  /// This element specifies the Universal Data Link (UDL) connection string used to reconnect to an external data source. 
  /// The string within this element's val attribute shall contain the connection string that the hosting application 
  /// shall pass to a external data source access application to enable the WordprocessingML document to be reconnected 
  /// to the specified external data source.
  /// <para>
  ///If this string is omitted, then no UDL connection string shall be associated with the ODSO data for this mail merge.
  /// </para>
  /// <para>
  /// This connection string is only used under the following conditions:
  /// </para>
  /// <list type="bullet">
  ///  <item>
  ///    The dataType element (§17.14.10) is set to native
  ///  </item>
  ///  <item>
  ///    The current application is able to use the information contained in the odso element (§17.14.25) to access the data source
  ///  </item>
  /// </list>
  /// <para>
  /// [Guidance: In this case, using the connection string in the udl element provides an equal or greater amount of information 
  /// for the mail merge data source for clients which can consume it. end guidance]
  /// </para>
  /// </summary>
  [DataMember]
  public string? UdlConnectionString
  {
    get => _Element?.GetStringVal<DXW.UdlConnectionString>();
    set => _Element.SetStringVal<DXW.UdlConnectionString>(value);
  }

  /// <summary>
  /// This element specifies the particular set of data that a source or merged WordprocessingML document shall be connected to 
  /// within an external data source containing multiple data sets. In other words, when connecting to a WordprocessingML document 
  /// to an external data source that can have more than one repository of data within it, such as a database with multiple tables 
  /// or a spreadsheet with multiple worksheets, this element is used to distinguish the specific table or spreadsheet 
  /// from which data is imported from within the external data source.
  /// </summary>
  [DataMember]
  public string? DataSourceTableName
  {
    get => _Element?.GetStringVal<DXW.DataSourceTableName>();
    set => _Element.SetStringVal<DXW.DataSourceTableName>(value);
  }

  /// <summary>
  /// This element specifies the character which shall be interpreted as the column delimiter used to separate columns within external data sources. 
  /// The character representing the specific delimiter used for the external data source referenced by a source or merged WordprocessingML document
  /// is specified via a decimal number representing the decimal number for the Unicode character representation within this element's val attribute.
  /// </summary>
  [DataMember]
  public UInt16? ColumnDelimiter
  {
    get => (UInt16?)_Element?.GetIntVal<DXW.DataSourceTableName>();
    set => _Element.SetIntVal<DXW.DataSourceTableName>(value);
  }
}
