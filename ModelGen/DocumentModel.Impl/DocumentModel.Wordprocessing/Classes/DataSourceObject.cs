namespace DocumentModel.Wordprocessing;

/// <summary>
/// Office Data Source Object Settings.
/// </summary>
public class DataSourceObjectImpl: ModelElementImpl, DataSourceObject
{
  public DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DataSourceObject?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// UDL Connection String.
  /// </summary>
  public String? UdlConnectionString
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Source Table Name.
  /// </summary>
  public String? DataSourceTableName
  {
    get;
    set;
  }
  
  /// <summary>
  /// ODSO Data Source File Path.
  /// </summary>
  public RelationshipType? SourceReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Column Delimiter for Data Source.
  /// </summary>
  public UInt32? ColumnDelimiter
  {
    get;
    set;
  }
  
  /// <summary>
  /// ODSO Data Source Type.
  /// </summary>
  public MailMergeSourceKind? MailMergeSource
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeSource>();
        return (MailMergeSourceKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeSource>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.MailMergeSource{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// First Row of Data Source Contains Column Names.
  /// </summary>
  public Boolean? FirstRowHeader
  {
    get;
    set;
  }
  
  public Collection<FieldMapData>? FieldMapDatas
  {
    get;
    set;
  }
  
  public RelationshipType? RecipientDataReference
  {
    get;
    set;
  }
  
}
