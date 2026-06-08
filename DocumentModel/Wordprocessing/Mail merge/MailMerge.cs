namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Mail Merge Settings.
/// </summary>
public class IMailMerge: ModelElement
{
  /// <summary>
  ///   ISource IDocument Type.
  /// </summary>
  public MailMergeDocumentKind? MainDocumentType { get; set; }

  /// <summary>
  ///   Query Contains Link Ito External Query File.
  /// </summary>
  public bool? LinkToQuery { get; set; }

  /// <summary>
  ///   Data ISource Type.
  /// </summary>
  public MailMergeDataKind? DataType { get; set; }

  /// <summary>
  ///   Data ISource Connection String.
  /// </summary>
  public string? ConnectString { get; set; }

  /// <summary>
  ///   Query For Data ISource Records To Merge.
  /// </summary>
  public string? Query { get; set; }

  /// <summary>
  ///   Data ISource File Path.
  /// </summary>
  public RelationshipType? DataSourceReference { get; set; }

  /// <summary>
  ///   Header Definition File Path.
  /// </summary>
  public RelationshipType? HeaderSource { get; set; }

  /// <summary>
  ///   Remove Blank ILines from Merged IDocuments.
  /// </summary>
  public bool? DoNotSuppressBlankLines { get; set; }

  /// <summary>
  ///   Merged IDocument Destination.
  /// </summary>
  public MailMergeDestinationKind? Destination { get; set; }

  /// <summary>
  ///   IColumn Containing E-mail Address.
  /// </summary>
  public string? AddressFieldName { get; set; }

  /// <summary>
  ///   Merged E-mail or Fax Subject ILine.
  /// </summary>
  public string? MailSubject { get; set; }

  /// <summary>
  ///   Merged IDocument To E-Mail Attachment.
  /// </summary>
  public bool? MailAsAttachment { get; set; }

  /// <summary>
  ///   IView Merged Data Within IDocument.
  /// </summary>
  public bool? ViewMergedData { get; set; }

  /// <summary>
  ///   Record Currently Displayed In Merged IDocument.
  /// </summary>
  public Int32? ActiveRecord { get; set; }

  /// <summary>
  ///   Mail Merge Error Reporting Setting.
  /// </summary>
  public Int32? CheckErrors { get; set; }

  /// <summary>
  ///   Office Data ISource Object Settings.
  /// </summary>
  public DataSourceObject? DataSourceObject { get; set; }
}
