namespace DocumentModel.Wordprocessing;


/// <summary>
///   Mail Merge Settings.
/// </summary>
public partial class MailMerge: ModelElement<DXW.MailMerge>
{
  public MailMerge(): base(){ }
  
  public MailMerge(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MailMerge(DXW.MailMerge openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Source Document Type.
  /// </summary>
  [DataMember]
  public DMW.MailMergeDocumentKind? MainDocumentType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DMW.MailMergeDocumentKind>(_ExistingElement.GetFirstChild<DXW.MainDocumentType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MainDocumentType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DMW.MailMergeDocumentKind>(itemElement, (DMW.MailMergeDocumentKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.MainDocumentType, DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DMW.MailMergeDocumentKind>((DMW.MailMergeDocumentKind)value));
    }
  }
  
  
  /// <summary>
  ///   Query Contains Link to External Query File.
  /// </summary>
  [DataMember]
  public DMW.LinkToQuery? LinkToQuery
  {
    get
    {
      return _Element?.GetObject<DMW.LinkToQuery,DXW.LinkToQuery>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LinkToQuery,DXW.LinkToQuery>(value);
    }
  }
  
  
  /// <summary>
  ///   Data Source Type.
  /// </summary>
  [DataMember]
  public DMW.MailMergeDataKind? DataType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DMW.MailMergeDataKind>(_ExistingElement.GetFirstChild<DXW.DataType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DataType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DMW.MailMergeDataKind>(itemElement, (DMW.MailMergeDataKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.DataType, DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DMW.MailMergeDataKind>((DMW.MailMergeDataKind)value));
    }
  }
  
  
  /// <summary>
  ///   Data Source Connection String.
  /// </summary>
  [DataMember]
  public DMW.ConnectString? ConnectString
  {
    get
    {
      return _Element?.GetObject<DMW.ConnectString,DXW.ConnectString>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ConnectString,DXW.ConnectString>(value);
    }
  }
  
  
  /// <summary>
  ///   Query For Data Source Records To Merge.
  /// </summary>
  [DataMember]
  public DMW.Query? Query
  {
    get
    {
      return _Element?.GetObject<DMW.Query,DXW.Query>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Query,DXW.Query>(value);
    }
  }
  
  
  /// <summary>
  ///   Data Source File Path.
  /// </summary>
  [DataMember]
  public DMW.DataSourceReference? DataSourceReference
  {
    get
    {
      return _Element?.GetObject<DMW.DataSourceReference,DXW.DataSourceReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DataSourceReference,DXW.DataSourceReference>(value);
    }
  }
  
  
  /// <summary>
  ///   Header Definition File Path.
  /// </summary>
  [DataMember]
  public DMW.HeaderSource? HeaderSource
  {
    get
    {
      return _Element?.GetObject<DMW.HeaderSource,DXW.HeaderSource>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.HeaderSource,DXW.HeaderSource>(value);
    }
  }
  
  
  /// <summary>
  ///   Remove Blank Lines from Merged Documents.
  /// </summary>
  [DataMember]
  public DMW.DoNotSuppressBlankLines? DoNotSuppressBlankLines
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotSuppressBlankLines,DXW.DoNotSuppressBlankLines>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotSuppressBlankLines,DXW.DoNotSuppressBlankLines>(value);
    }
  }
  
  
  /// <summary>
  ///   Merged Document Destination.
  /// </summary>
  [DataMember]
  public DMW.MailMergeDestinationKind? Destination
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DMW.MailMergeDestinationKind>(_ExistingElement.GetFirstChild<DXW.Destination>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Destination>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DMW.MailMergeDestinationKind>(itemElement, (DMW.MailMergeDestinationKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Destination, DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DMW.MailMergeDestinationKind>((DMW.MailMergeDestinationKind)value));
    }
  }
  
  
  /// <summary>
  ///   Column Containing E-mail Address.
  /// </summary>
  [DataMember]
  public DMW.AddressFieldName? AddressFieldName
  {
    get
    {
      return _Element?.GetObject<DMW.AddressFieldName,DXW.AddressFieldName>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AddressFieldName,DXW.AddressFieldName>(value);
    }
  }
  
  
  /// <summary>
  ///   Merged E-mail or Fax Subject Line.
  /// </summary>
  [DataMember]
  public DMW.MailSubject? MailSubject
  {
    get
    {
      return _Element?.GetObject<DMW.MailSubject,DXW.MailSubject>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MailSubject,DXW.MailSubject>(value);
    }
  }
  
  
  /// <summary>
  ///   Merged Document To E-Mail Attachment.
  /// </summary>
  [DataMember]
  public DMW.MailAsAttachment? MailAsAttachment
  {
    get
    {
      return _Element?.GetObject<DMW.MailAsAttachment,DXW.MailAsAttachment>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MailAsAttachment,DXW.MailAsAttachment>(value);
    }
  }
  
  
  /// <summary>
  ///   View Merged Data Within Document.
  /// </summary>
  [DataMember]
  public DMW.ViewMergedData? ViewMergedData
  {
    get
    {
      return _Element?.GetObject<DMW.ViewMergedData,DXW.ViewMergedData>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ViewMergedData,DXW.ViewMergedData>(value);
    }
  }
  
  
  /// <summary>
  ///   Record Currently Displayed In Merged Document.
  /// </summary>
  [DataMember]
  public DMW.ActiveRecord? ActiveRecord
  {
    get
    {
      return _Element?.GetObject<DMW.ActiveRecord,DXW.ActiveRecord>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ActiveRecord,DXW.ActiveRecord>(value);
    }
  }
  
  
  /// <summary>
  ///   Mail Merge Error Reporting Setting.
  /// </summary>
  [DataMember]
  public DMW.CheckErrors? CheckErrors
  {
    get
    {
      return _Element?.GetObject<DMW.CheckErrors,DXW.CheckErrors>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.CheckErrors,DXW.CheckErrors>(value);
    }
  }
  
  
  /// <summary>
  ///   Office Data Source Object Settings.
  /// </summary>
  [DataMember]
  public DMW.DataSourceObject? DataSourceObject
  {
    get
    {
      return _Element?.GetObject<DMW.DataSourceObject,DXW.DataSourceObject>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DataSourceObject,DXW.DataSourceObject>(value);
    }
  }
  
}
