namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies how a column specified in the external data source that has been connected to a WordprocessingML document 
/// shall be mapped to the pre-defined MERGEFIELD fields within the given merged document's contents. 
/// Each instance of a fieldMapData element contains the information needed to map one column in the external data source 
/// to a single type of pre-defined MERGEFIELD field for the purposes of the mail merge in the current document.
/// </summary>
[DataContract]
public partial class FieldMapData : IOpenXmlElementMappedObject
{
  public FieldMapData()
  {
    _Element = new DXW.FieldMapData();
  }

  public FieldMapData(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.FieldMapData)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public FieldMapData(DXW.FieldMapData openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.FieldMapData _Element { get; private set; }

  /// <summary>
  /// This element specifies the language which shall be used for this phonetic guide.
  /// </summary>
  [DataMember]
  public String? LanguageId
  {
    get => _Element?.GetStringVal<DXW.LanguageId>();
    set => _Element.SetStringVal<DXW.LanguageId>(value);
  }

  /// <summary>
  /// This element specifies if a given mail merge field has been mapped to a column in the given external data source or not.
  /// <para>
  /// If this element is omitted, then the field mapping shall be considered to be of type null (i.e. not mapped).This element specifies what the result which shall be generated when a mail merge is carried out on a given WordprocessingML source document. In other words, this element is used to specify what is to be done with the merged documents that result from populating the fields within a given merged WordprocessingML document with data from the specified external data source.
  /// </para>
  /// </summary>
  [DataMember]
  public DXW.MailMergeOdsoFieldValues? MailMergeFieldType
  {
    get => _Element?.GetEnumVal<DXW.MailMergeOdsoFieldValues, DXW.MailMergeFieldType>();
    set => _Element.SetEnumVal<DXW.MailMergeOdsoFieldValues, DXW.MailMergeFieldType>(value);
  }

  /// <summary>
  /// This element specifies that the contents of the AddressBlock MERGEFIELD field shall be dynamically ordered 
  /// based on the country associated with the current record or if the country-invariant version of the address 
  /// field shall be used in its place. [Rationale: When a source document is combined with the contents of a data source 
  /// in order to produce multiple merged documents, it is often necessary to use an address form 
  /// specific to the destination country for each particular record in the data source, 
  /// rather than one static address form for all records. end rationale] 
  /// If this element is set to true, then the mail merge shall use an address form suited to the country 
  /// associated with the current record in the external data source.
  /// <para>
  /// If this element is omitted, then the form of the address shall be dynamically determined 
  /// based on the country specified in the current record. This element specifies the document type of a given WordprocessingML source document.
  /// </para>
  /// </summary>
  [DataMember]
  public Boolean? DynamicAddress
  {
    get => _Element?.GetBooleanVal<DXW.DynamicAddress>();
    set => _Element.SetBooleanVal<DXW.DynamicAddress>(value);
  }

  /// <summary>
  /// This element specifies the category into which the current glossary document part shall be classified. 
  /// This classification can consist of any string value as determined by its contents, 
  /// and shall only be used to classify and sort this entry (via an application or a user interface).
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.GetStringVal<DXW.Name>();
    set => _Element.SetStringVal<DXW.Name>(value);
  }

  /// <summary>
  /// This element specifies the predefined WordprocessingML MERGEFIELD field name which shall be mapped to the column number specified by the column element (§17.14.6) within this field mapping. [Guidance: This element allows the current column from the specified data source to be mapped to a predefined field name, allowing applications to have one standard set of field names to use regardless of the data source column names, for example, to create the address formats to place into an ADDRESSBLOCK field. end guidance]
  /// <para>
  /// If this element is omitted, then the current data source column mapping shall not have a predefined merge field name mapped to its contents, and shall only be referenced via the data source column name specified by the name element (§17.14.24) when referenced by one or more MERGEFIELD fields. If the application does not have a predefined merge field whose name matches the name specified using the val attribute, then this element can be ignored.
  /// </para>
  /// </summary>
  [DataMember]
  public String? MappedName
  {
    get => _Element?.GetStringVal<DXW.MappedName>();
    set => _Element.SetStringVal<DXW.MappedName>(value);
  }

  /// <summary>
  /// This element specifies the zero-based index of the column within a given external data source 
  /// which shall be mapped to the local name of a specific MERGEFIELD field specified by the parent field mapping data. 
  /// It specifies this index value, which is used to look up the appropriate column in the data source.
  /// <para>
  /// If this element is omitted, or its value exceeds the number of columns in the associated data source, 
  /// then the index of the referenced column shall be assumed to be 0.
  /// </para>
  /// </summary>
  [DataMember]
  public Int32? ColumnIndex
  {
    get => _Element?.GetInt32Val<DXW.ColumnIndex>();
    set => _Element.SetInt32Val<DXW.ColumnIndex>(value);
  }

}
