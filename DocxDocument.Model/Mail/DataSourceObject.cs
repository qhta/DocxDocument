
namespace DocxDocument.Model;

public class DataSourceObject: IDataSourceObject
{
  /// <summary> 
  /// This element specifies the character which shall be interpreted as the column delimiter used to separate columns within external data sources. The character representing the specific delimiter used for the external data source referenced by a source or merged WordprocessingML document is specified via a decimal number representing the decimal number for the Unicode character representation within this element's val attribute.
  ///</summary> 
  [XmlAttribute]
  public int? ColumnDelimiter { get; set; }

  /// <summary> 
  /// This element specifies the particular set of data that a source or merged WordprocessingML document shall be connected to within an external data source containing multiple data sets. In other words, when connecting to a WordprocessingML document to an external data source that can have more than one repository of data within it, such as a database with multiple tables or a spreadsheet with multiple worksheets, this element is used to distinguish the specific table or spreadsheet from which data is imported from within the external data source.
  ///</summary> 
  [XmlAttribute]
  public string? DataSourceTableName { get; set; }

  /// <summary> 
  /// This element specifies that a hosting application shall treat the first row of data in the specified external data source as a header row containing the names of each column in the data source, rather than data to populate mapped fields in a merged document. When present, this information shall not change the indices specified in the recipientData elements (§17.14.27), but shall indicate that the first row is not part of the mail merge when it is performed.
  ///</summary> 
  [XmlAttribute]
  public bool? FirstRowHeader { get; set; }

  /// <summary> 
  /// This element specifies the type of external data source to be connected to via as part of the ODSO connection information for this mail merge. This setting is purely a suggestion of the data source type which is being used for this mail merge, and can be ignored in favor of an alternative mechanism if one is present.
  ///</summary> 
  [XmlAttribute]
  public MailMergeSourceType? MailMergeSource { get; set; }

  /// <summary> 
  /// This element specifies the relationship whose target is the location of the external data source to be connected to a given WordprocessingML document to perform the mail merge (for a source document) or to find the associated field data (for a merged document) when the merge type, specified using the dataType element (§17.14.10), is set to native.
  ///</summary> 
  [XmlAttribute]
  public Relationship? SourceReference { get; set; }

  /// <summary> 
  /// This element specifies the Universal Data Link (UDL) connection string used to reconnect to an external data source. The string within this element's val attribute shall contain the connection string that the hosting application shall pass to a external data source access application to enable the WordprocessingML document to be reconnected to the specified external data source.
  ///</summary> 
  [XmlAttribute]
  public string? UdlConnectionString { get; set; }


}