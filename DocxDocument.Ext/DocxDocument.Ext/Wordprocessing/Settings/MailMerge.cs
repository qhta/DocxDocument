namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies all of the mail merge information for a document that has been connected 
/// to an external data source as part of a mail merge operation.
/// <para>
/// The document which contains this mail merge data can be of one of two types:
/// </para>
/// <list type="bullet">
///   <item>
///    A source document, the document which contains all of the information for the mail merge, and is used in conjunction with an application to connect to an external data source and create one document for each record in that data source.
///   </item>
///   <item>
///    A merged document, a document which contains all of the information for the mail merge as well as a reference to a single specific record which shall be used to populate the values of all of the merge fields in that document.
///   </item>
/// </list>
/// <para>
/// The information in this element shall contain all data needed to connect to a data source 
/// and populate any merge fields in the document with data from that data source.
/// </para>
/// </summary>
[DataContract]
public partial class MailMerge :  ModelElement<DXW.MailMerge>
{
  public MailMerge(): base(){ }

  public MailMerge(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public MailMerge(DXW.MailMerge openXmlElement): base(openXmlElement) { } 

  /// <summary>
  /// This element specifies that the hosting application shall display the given record 
  /// from the specified external data source in place of the MERGEFIELD fields 
  /// Its data is mapped to via the fieldMapData element in a merged document. When this element is present, 
  /// it shall specify the one-based index of the record from that data source which shall be used to populate this document.
  /// If the activeRecord element is omitted with the viewMergedData element's val attribute equal to true, 
  /// the hosting application shall behave as if the activeRecord element's val attribute was equal to 1. 
  /// <para>
  /// If the ViewMergedData element is omitted or present with a val attribute equal to 0 or false, then this element shall be ignored. 
  /// If the activeRecord record is given a val attribute that is less than one or greater than the number of records 
  /// in the specified external data source, the hosting application shall treat this val attribute as if it were equal to 1.
  /// </para>
  /// </summary>
  [DataMember]
  public int? ActiveRecord
  {
    get => _Element?.GetIntVal<DXW.ActiveRecord>();
    set => _Element.SetIntVal<DXW.ActiveRecord>(value);
  }

  /// <summary>
  /// This element specifies the type of error reporting which shall be conducted by an application 
  /// when performing a mail merge against the specified source data.
  /// <para>
  /// The type of error reporting implied by this element shall be defined as follows:
  /// </para>
  /// <list type="bullet">
  ///   <item>
  ///     Simulate the population of fields with mapped external data and report errors in a new document if the val attribute is equal to 1.
  ///   </item>
  ///   <item>
  ///     While populating fields with mapped external data, pausing to report each error as it occurs if the val attribute is equal to 2.
  ///   </item>
  ///   <item>
  ///     Populate fields with mapped external data and report errors in a new document if the val attribute is equal to 3.
  ///   </item>
  ///   <item>
  ///     Application-defined behaviors can be used if the val attribute is equal to any other value.
  ///   </item>
  /// </list>
  /// <para>
  /// If this element is omitted, or its value is set to a value outside of those specified above 
  /// that is not understood by the hosting application, then its value shall be assumed to be 2.
  /// </para>
  /// </summary>
  [DataMember]
  public int? CheckErrors
  {
    get => _Element?.GetIntVal<DXW.CheckErrors>();
    set => _Element.SetIntVal<DXW.CheckErrors>(value);
  }

  /// <summary>
  /// This element specifies the type of external data source to be connected to via the Dynamic Data Exchange system 
  /// (such as a spreadsheet or database), or the alternative method of data access if the Dynamic Data Exchange system is not used. 
  /// This setting is purely a suggestion of the data source access mechanism which shall be used, 
  /// and can be ignored in favor of an alternative mechanism if one is present.
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.MailMergeDataKind? DataType
  {
    get => _Element?.GetEnumVal<DMW.MailMergeDataKind, DXW.DataType>();
    set => _Element.SetEnumVal<DMW.MailMergeDataKind, DXW.DataType>(value);
  }

  /// <summary>
  /// This element specifies what the result which shall be generated when a mail merge is carried out on a given WordprocessingML source document. In other words, this element is used to specify what is to be done with the merged documents that result from populating the fields within a given merged WordprocessingML document with data from the specified external data source.
  /// <para>
  ///   If this element is omitted, then the default destination of merged documents shall be assumed to be of type newDocument.
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.MailMergeDestinationKind? Destination
  {
    get => _Element?.GetEnumVal<DMW.MailMergeDestinationKind, DXW.Destination>();
    set => _Element.SetEnumVal<DMW.MailMergeDestinationKind, DXW.Destination>(value);
  }

  /// <summary>
  /// This element specifies the document type of a given WordprocessingML source document.
  /// <para>
  /// If this element is omitted, then its value shall be assumed to be formLetters.
  /// </para>
  /// <para>
  /// [Note: This element is generally used in conjunction with the behavior of an application to customize aspects of the mail merge user interface and experience independent of the WordprocessingML file format. For example, if a given WordprocessingML merged document contains a mainDocumentType element with its val attribute equal to envelopes, the hosting application can surface a piece of user interface specific to creating envelopes when the given document is opened.
  /// </para>
  /// <para>
  /// In addition, what a hosting application does with the documents that result from importing external data into specified fields can be determined based on the mainDocumentType element, but other than this, is independent of a given merged document's WordprocessingML. For example, if a given merged WordprocessingML document contains a mainDocumentType element with its val attribute equal to email, the hosting application can call a email service after importing external data into specified fields, in order to generate emails containing the resulting documents.
  /// </para>
  /// <para>
  /// WordprocessingML simply provides the mainDocumentType that can serve as a trigger for an application to surface user interface specific to a document type of mail merge. end note]
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.MailMergeDocumentKind? MainDocumentType
  {
    get => _Element?.GetEnumVal<DMW.MailMergeDocumentKind, DXW.MainDocumentType>();
    set => _Element.SetEnumVal<DMW.MailMergeDocumentKind, DXW.MainDocumentType>(value);
  }

  /// <summary>
  /// This element specifies a group of additional settings for the mail merge information 
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
  [DataMember]
  public DMW.DataSourceObject? DataSourceObject
  {
    get => _Element?.GetObject<DMW.DataSourceObject, DXW.DataSourceObject>();
    set => _Element.SetObject<DMW.DataSourceObject, DXW.DataSourceObject>(value);
  }

  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DataSourceObject" /> <c>&lt;w:odso></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.LinkToQuery" /> <c>&lt;w:linkToQuery></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressBlankLines" /> <c>&lt;w:doNotSuppressBlankLines></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MailAsAttachment" /> <c>&lt;w:mailAsAttachment></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ViewMergedData" /> <c>&lt;w:viewMergedData></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DataSourceReference" /> <c>&lt;w:dataSource></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.HeaderSource" /> <c>&lt;w:headerSource></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ConnectString" /> <c>&lt;w:connectString></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Query" /> <c>&lt;w:query></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.AddressFieldName" /> <c>&lt;w:addressFieldName></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MailSubject" /> <c>&lt;w:mailSubject></c></description></item>

}
