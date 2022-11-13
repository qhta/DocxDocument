using System.Xml.Linq;

using DocxDocument.Reader;

namespace DocxDocument.Model;

public class MailMergeSettings : DocxBasedElement<WD.MailMerge>, IMailMergeSettings
{
  public MailMergeSettings() : base(new WD.MailMerge())
  {
  }

  public MailMergeSettings(WD.MailMerge element) : base(element)
  {
  }

  /// <summary> 
  /// Record Currently Displayed In Merged Document.
  ///</summary> 
  public int? ActiveRecord
  {
    get => DocxElement.ActiveRecord?.Val?.Value; 
    set => DocxElement.ActiveRecord = (value != null) ? new WD.ActiveRecord{ Val = value } : null;
  }

  /// <summary> 
  /// Column Containing E-mail Address.
  ///</summary> 
  public string? AddressFieldName
  {
    get => DocxElement.AddressFieldName?.Val?.Value;
    set => DocxElement.AddressFieldName = (value != null) ? new WD.AddressFieldName { Val = value } : null;
  }

  /// <summary> 
  /// Mail Merge Error Reporting Setting.
  ///</summary> 
  public int? CheckErrors
  {
    get => DocxElement.CheckErrors?.Val?.Value;
    set => DocxElement.CheckErrors = (value != null) ? new WD.CheckErrors { Val = value } : null;
  }

  /// <summary> 
  /// Data Source Connection String.
  ///</summary> 
  public string? ConnectString
  {
    get => DocxElement.ConnectString?.Val?.Value;
    set => DocxElement.ConnectString = (value != null) ? new WD.ConnectString { Val = value } : null;
  }

  /// <summary> 
  /// Office Data Source Object Settings.
  ///</summary> 
  public IDataSourceObject? DataSourceObject
  {
    get => DocxElement.ReadObject<DM.DataSourceObject, WD.DataSourceObject>();
    set => DocxElement.WriteObject<DM.DataSourceObject, WD.DataSourceObject>(value as DataSourceObject);
  }

  /// <summary> 
  /// Data Source Type.
  ///</summary> 
  public DM.MailMergeDataType? DataType
  {
    get => (DM.MailMergeDataType?)DocxElement.ReadEnum<WD.MailMergeDataValues, WD.DataType>();
    set => DocxElement.WriteEnum<WD.MailMergeDataValues, WD.DataType>((WD.MailMergeDataValues?)value);
  }

  /// <summary> 
  /// Merged Document Destination.
  ///</summary> 
  public DM.MailMergeDestinationType? Destination
  {
    get => (DM.MailMergeDestinationType?)DocxElement.ReadEnum<WD.MailMergeDestinationValues, WD.Destination>();
    set => DocxElement.WriteEnum<WD.MailMergeDestinationValues, WD.Destination>((WD.MailMergeDestinationValues?)value);
  }

  /// <summary> 
  /// Remove Blank Lines from Merged Documents.
  ///</summary> 
  public bool? DoNotSuppressBlankLines
  {
    get => DocxElement.ReadOnOffType<WD.DoNotSuppressBlankLines>();
    set => DocxElement.WriteOnOffType<WD.DoNotSuppressBlankLines>(value);
  }

  /// <summary> 
  /// Query Contains Link to External Query File.
  ///</summary> 
  public bool? LinkToQuery
  {
    get => DocxElement.ReadOnOffType<WD.LinkToQuery>();
    set => DocxElement.WriteOnOffType<WD.LinkToQuery>(value);
  }

  /// <summary> 
  /// Merged Document To E-Mail Attachment.
  ///</summary> 
  public bool? MailAsAttachment
  {
    get => DocxElement.ReadOnOffType<WD.MailAsAttachment>();
    set => DocxElement.WriteOnOffType<WD.MailAsAttachment>(value);
  }

  /// <summary> 
  /// Merged E-mail or Fax Subject Line.
  ///</summary> 
  public string? MailSubject
  {
    get => DocxElement.ReadStringType<WD.MailSubject>();
    set => DocxElement.WriteStringType<WD.MailSubject>(value);
  }

  /// <summary> 
  /// Source Document Type.
  ///</summary> 
  public DM.MailMergeDocumentType? MainDocumentType
  {
    get => (DM.MailMergeDocumentType?)DocxElement.ReadEnum<WD.MailMergeDocumentValues, WD.MainDocumentType>();
    set => DocxElement.WriteEnum<WD.MailMergeDocumentValues, WD.MainDocumentType>((WD.MailMergeDocumentValues?)value);
  }

  /// <summary> 
  /// Query For Data Source Records To Merge.
  ///</summary> 
  public string? Query
  {
    get => DocxElement.ReadStringType<WD.Query>();
    set => DocxElement.WriteStringType<WD.Query>(value);
  }

  /// <summary> 
  /// View Merged Data Within Document.
  ///</summary> 
  public bool? ViewMergedData
  {
    get => DocxElement.ReadOnOffType<WD.ViewMergedData>();
    set => DocxElement.WriteOnOffType<WD.ViewMergedData>(value);
  }

  /// <summary> 
  /// Header Definition File Path.
  ///</summary> 
  public Relationship? HeaderSource
  {
    get => DocxElement.ReadRelationshipType<WD.HeaderSource>();
    set => DocxElement.WriteRelationshipType<WD.HeaderSource>(value);
  }

  /// <summary> 
  /// Data Source File Path.
  ///</summary> 
  public Relationship? DataSourceReference
  {
    get => DocxElement.ReadRelationshipType<WD.DataSourceReference>();
    set => DocxElement.WriteRelationshipType<WD.DataSourceReference>(value);
  }
}