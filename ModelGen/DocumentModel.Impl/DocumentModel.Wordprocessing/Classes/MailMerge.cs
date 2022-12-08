namespace DocumentModel.Wordprocessing;

/// <summary>
/// Mail Merge Settings.
/// </summary>
public class MailMergeImpl: ModelElementImpl, MailMerge
{
  public DocumentFormat.OpenXml.Wordprocessing.MailMerge? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MailMerge?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Source Document Type.
  /// </summary>
  public MailMergeDocumentKind? MainDocumentType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MainDocumentType>();
        return (MailMergeDocumentKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MainDocumentType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.MainDocumentType{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Query Contains Link to External Query File.
  /// </summary>
  public Boolean? LinkToQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Source Type.
  /// </summary>
  public MailMergeDataKind? DataType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataType>();
        return (MailMergeDataKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.DataType{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Data Source Connection String.
  /// </summary>
  public String? ConnectString
  {
    get;
    set;
  }
  
  /// <summary>
  /// Query For Data Source Records To Merge.
  /// </summary>
  public String? Query
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Source File Path.
  /// </summary>
  public RelationshipType? DataSourceReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Header Definition File Path.
  /// </summary>
  public RelationshipType? HeaderSource
  {
    get;
    set;
  }
  
  /// <summary>
  /// Remove Blank Lines from Merged Documents.
  /// </summary>
  public Boolean? DoNotSuppressBlankLines
  {
    get;
    set;
  }
  
  /// <summary>
  /// Merged Document Destination.
  /// </summary>
  public MailMergeDestinationKind? Destination
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Destination>();
        return (MailMergeDestinationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Destination>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.Destination{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Column Containing E-mail Address.
  /// </summary>
  public String? AddressFieldName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Merged E-mail or Fax Subject Line.
  /// </summary>
  public String? MailSubject
  {
    get;
    set;
  }
  
  /// <summary>
  /// Merged Document To E-Mail Attachment.
  /// </summary>
  public Boolean? MailAsAttachment
  {
    get;
    set;
  }
  
  /// <summary>
  /// View Merged Data Within Document.
  /// </summary>
  public Boolean? ViewMergedData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Record Currently Displayed In Merged Document.
  /// </summary>
  public Int32? ActiveRecord
  {
    get;
    set;
  }
  
  /// <summary>
  /// Mail Merge Error Reporting Setting.
  /// </summary>
  public Int32? CheckErrors
  {
    get;
    set;
  }
  
  /// <summary>
  /// Office Data Source Object Settings.
  /// </summary>
  public DataSourceObject? DataSourceObject
  {
    get;
    set;
  }
  
}
