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
      var element = _Element?.GetFirstChild<DXW.LinkToQuery>();
      if (element != null)
        return LinkToQueryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LinkToQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinkToQueryConverter.CreateOpenXmlElement<DXW.LinkToQuery>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ConnectString>();
      if (element != null)
        return ConnectStringConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ConnectString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectStringConverter.CreateOpenXmlElement<DXW.ConnectString>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Query>();
      if (element != null)
        return QueryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Query>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = QueryConverter.CreateOpenXmlElement<DXW.Query>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DataSourceReference>();
      if (element != null)
        return DataSourceReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DataSourceReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataSourceReferenceConverter.CreateOpenXmlElement<DXW.DataSourceReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.HeaderSource>();
      if (element != null)
        return HeaderSourceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.HeaderSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeaderSourceConverter.CreateOpenXmlElement<DXW.HeaderSource>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotSuppressBlankLines>();
      if (element != null)
        return DoNotSuppressBlankLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotSuppressBlankLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotSuppressBlankLinesConverter.CreateOpenXmlElement<DXW.DoNotSuppressBlankLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AddressFieldName>();
      if (element != null)
        return AddressFieldNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AddressFieldName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AddressFieldNameConverter.CreateOpenXmlElement<DXW.AddressFieldName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.MailSubject>();
      if (element != null)
        return MailSubjectConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MailSubject>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MailSubjectConverter.CreateOpenXmlElement<DXW.MailSubject>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.MailAsAttachment>();
      if (element != null)
        return MailAsAttachmentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MailAsAttachment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MailAsAttachmentConverter.CreateOpenXmlElement<DXW.MailAsAttachment>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ViewMergedData>();
      if (element != null)
        return ViewMergedDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ViewMergedData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ViewMergedDataConverter.CreateOpenXmlElement<DXW.ViewMergedData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ActiveRecord>();
      if (element != null)
        return ActiveRecordConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ActiveRecord>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ActiveRecordConverter.CreateOpenXmlElement<DXW.ActiveRecord>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.CheckErrors>();
      if (element != null)
        return CheckErrorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.CheckErrors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckErrorsConverter.CreateOpenXmlElement<DXW.CheckErrors>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DataSourceObject>();
      if (element != null)
        return DataSourceObjectConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DataSourceObject>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataSourceObjectConverter.CreateOpenXmlElement<DXW.DataSourceObject>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
