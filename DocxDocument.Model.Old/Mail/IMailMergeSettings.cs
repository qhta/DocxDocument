namespace DocxDocument.Model;

public interface IMailMergeSettings
{
  /// <summary> 
  /// Record Currently Displayed In Merged Document.
  ///</summary> 
  public int? ActiveRecord { get; set; }

  /// <summary> 
  /// Column Containing E-mail Address.
  ///</summary> 
  public string? AddressFieldName { get; set; }

  /// <summary> 
  /// Mail Merge Error Reporting Setting.
  ///</summary> 
  public int? CheckErrors { get; set; }

  /// <summary> 
  /// Data Source Connection String.
  ///</summary> 
  public string? ConnectString { get; set; }

  /// <summary> 
  /// Office Data Source Object Settings.
  ///</summary> 
  public IDataSourceObject? DataSourceObject { get; set; }

  /// <summary> 
  /// Data Source Type.
  ///</summary> 
  public DM.MailMergeDataType? DataType { get; set; }

  /// <summary> 
  /// Merged Document Destination.
  ///</summary> 
  public DM.MailMergeDestinationType? Destination { get; set; }

  /// <summary> 
  /// Remove Blank Lines from Merged Documents.
  ///</summary> 
  public bool? DoNotSuppressBlankLines { get; set; }

  /// <summary> 
  /// Query Contains Link to External Query File.
  ///</summary> 
  public bool? LinkToQuery { get; set; }

  /// <summary> 
  /// Merged Document To E-Mail Attachment.
  ///</summary> 
  public bool? MailAsAttachment { get; set; }

  /// <summary> 
  /// Merged E-mail or Fax Subject Line.
  ///</summary> 
  public string? MailSubject { get; set; }

  /// <summary> 
  /// Source Document Type.
  ///</summary> 
  public DM.MailMergeDocumentType? MainDocumentType { get; set; }

  /// <summary> 
  /// Query For Data Source Records To Merge.
  ///</summary> 
  public string? Query { get; set; }

  /// <summary> 
  /// View Merged Data Within Document.
  ///</summary> 
  public bool? ViewMergedData { get; set; }

  /// <summary> 
  /// Header Definition File Path.
  ///</summary> 
  public Relationship? HeaderSource { get; set; }

  /// <summary> 
  /// Data Source File Path.
  ///</summary> 
  public Relationship? DataSourceReference { get; set; }
}