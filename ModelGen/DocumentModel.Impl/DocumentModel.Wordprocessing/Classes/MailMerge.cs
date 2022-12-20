namespace DocumentModel.Wordprocessing;

/// <summary>
/// Mail Merge Settings.
/// </summary>
public partial class MailMergeImpl: ModelElementImpl, MailMerge
{
  public DocumentFormat.OpenXml.Wordprocessing.MailMerge? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MailMerge?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MailMergeImpl(): base() {}
  
  public MailMergeImpl(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Source Document Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeDocumentKind? MainDocumentType
  {
    get => (DocumentModel.Wordprocessing.MailMergeDocumentKind?)OpenXmlElement?.MainDocumentType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MainDocumentType != null)
        {
          if (value is not null)
            OpenXmlElement.MainDocumentType.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues?)value;
          else
            OpenXmlElement.MainDocumentType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MainDocumentType = new DocumentFormat.OpenXml.Wordprocessing.MainDocumentType{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Query Contains Link to External Query File.
  /// </summary>
  public Boolean? LinkToQuery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkToQuery>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkToQuery>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.LinkToQuery();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Data Source Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeDataKind? DataType
  {
    get => (DocumentModel.Wordprocessing.MailMergeDataKind?)OpenXmlElement?.DataType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DataType != null)
        {
          if (value is not null)
            OpenXmlElement.DataType.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues?)value;
          else
            OpenXmlElement.DataType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DataType = new DocumentFormat.OpenXml.Wordprocessing.DataType{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Data Source Connection String.
  /// </summary>
  public String? ConnectString
  {
    get => (System.String?)OpenXmlElement?.ConnectString?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ConnectString != null)
        {
          if (value is not null)
            OpenXmlElement.ConnectString.Val = (System.String?)value;
          else
            OpenXmlElement.ConnectString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ConnectString = new DocumentFormat.OpenXml.Wordprocessing.ConnectString{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Query For Data Source Records To Merge.
  /// </summary>
  public String? Query
  {
    get => (System.String?)OpenXmlElement?.Query?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Query != null)
        {
          if (value is not null)
            OpenXmlElement.Query.Val = (System.String?)value;
          else
            OpenXmlElement.Query = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Query = new DocumentFormat.OpenXml.Wordprocessing.Query{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Data Source File Path.
  /// </summary>
  public DocumentModel.Wordprocessing.RelationshipType? DataSourceReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelationshipType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RelationshipTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelationshipType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RelationshipTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Header Definition File Path.
  /// </summary>
  public DocumentModel.Wordprocessing.RelationshipType? HeaderSource
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelationshipType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RelationshipTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelationshipType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RelationshipTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Remove Blank Lines from Merged Documents.
  /// </summary>
  public Boolean? DoNotSuppressBlankLines
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressBlankLines>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressBlankLines>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressBlankLines();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Merged Document Destination.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeDestinationKind? Destination
  {
    get => (DocumentModel.Wordprocessing.MailMergeDestinationKind?)OpenXmlElement?.Destination?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Destination != null)
        {
          if (value is not null)
            OpenXmlElement.Destination.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues?)value;
          else
            OpenXmlElement.Destination = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Destination = new DocumentFormat.OpenXml.Wordprocessing.Destination{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Column Containing E-mail Address.
  /// </summary>
  public String? AddressFieldName
  {
    get => (System.String?)OpenXmlElement?.AddressFieldName?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AddressFieldName != null)
        {
          if (value is not null)
            OpenXmlElement.AddressFieldName.Val = (System.String?)value;
          else
            OpenXmlElement.AddressFieldName = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AddressFieldName = new DocumentFormat.OpenXml.Wordprocessing.AddressFieldName{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Merged E-mail or Fax Subject Line.
  /// </summary>
  public String? MailSubject
  {
    get => (System.String?)OpenXmlElement?.MailSubject?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MailSubject != null)
        {
          if (value is not null)
            OpenXmlElement.MailSubject.Val = (System.String?)value;
          else
            OpenXmlElement.MailSubject = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MailSubject = new DocumentFormat.OpenXml.Wordprocessing.MailSubject{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Merged Document To E-Mail Attachment.
  /// </summary>
  public Boolean? MailAsAttachment
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailAsAttachment>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailAsAttachment>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.MailAsAttachment();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// View Merged Data Within Document.
  /// </summary>
  public Boolean? ViewMergedData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ViewMergedData>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ViewMergedData>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ViewMergedData();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Record Currently Displayed In Merged Document.
  /// </summary>
  public Int32? ActiveRecord
  {
    get => (System.Int32?)OpenXmlElement?.ActiveRecord?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ActiveRecord != null)
        {
          if (value is not null)
            OpenXmlElement.ActiveRecord.Val = (System.Int32?)value;
          else
            OpenXmlElement.ActiveRecord = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ActiveRecord = new DocumentFormat.OpenXml.Wordprocessing.ActiveRecord{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Mail Merge Error Reporting Setting.
  /// </summary>
  public Int32? CheckErrors
  {
    get => (System.Int32?)OpenXmlElement?.CheckErrors?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.CheckErrors != null)
        {
          if (value is not null)
            OpenXmlElement.CheckErrors.Val = (System.Int32?)value;
          else
            OpenXmlElement.CheckErrors = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.CheckErrors = new DocumentFormat.OpenXml.Wordprocessing.CheckErrors{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Office Data Source Object Settings.
  /// </summary>
  public DocumentModel.Wordprocessing.DataSourceObject? DataSourceObject
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceObject>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DataSourceObjectImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceObject>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DataSourceObjectImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
