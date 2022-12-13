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
  
  public DataSourceObjectImpl(): base() {}
  
  public DataSourceObjectImpl(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// UDL Connection String.
  /// </summary>
  public String? UdlConnectionString
  {
    get => (System.String?)OpenXmlElement?.UdlConnectionString?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.UdlConnectionString != null)
        {
          if (value is not null)
            OpenXmlElement.UdlConnectionString.Val = (System.String?)value;
          else
            OpenXmlElement.UdlConnectionString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.UdlConnectionString = new DocumentFormat.OpenXml.Wordprocessing.UdlConnectionString{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Data Source Table Name.
  /// </summary>
  public String? DataSourceTableName
  {
    get => (System.String?)OpenXmlElement?.DataSourceTableName?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DataSourceTableName != null)
        {
          if (value is not null)
            OpenXmlElement.DataSourceTableName.Val = (System.String?)value;
          else
            OpenXmlElement.DataSourceTableName = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DataSourceTableName = new DocumentFormat.OpenXml.Wordprocessing.DataSourceTableName{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ODSO Data Source File Path.
  /// </summary>
  public DocumentModel.Wordprocessing.RelationshipType? SourceReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Column Delimiter for Data Source.
  /// </summary>
  public UInt32? ColumnDelimiter
  {
    get => (System.UInt32?)OpenXmlElement?.ColumnDelimiter?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ColumnDelimiter != null)
        {
          if (value is not null)
            OpenXmlElement.ColumnDelimiter.Val = (System.UInt32?)value;
          else
            OpenXmlElement.ColumnDelimiter = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ColumnDelimiter = new DocumentFormat.OpenXml.Wordprocessing.ColumnDelimiter{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ODSO Data Source Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeSourceKind? MailMergeSource
  {
    get => (DocumentModel.Wordprocessing.MailMergeSourceKind?)OpenXmlElement?.MailMergeSource?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MailMergeSource != null)
        {
          if (value is not null)
            OpenXmlElement.MailMergeSource.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues?)value;
          else
            OpenXmlElement.MailMergeSource = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MailMergeSource = new DocumentFormat.OpenXml.Wordprocessing.MailMergeSource{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// First Row of Data Source Contains Column Names.
  /// </summary>
  public Boolean? FirstRowHeader
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FirstRowHeader>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FirstRowHeader>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.FirstRowHeader();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.FieldMapData>? FieldMapDatas
  {
    get
    {
      if (_FieldMapDatas != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>()
            .Select(item => new DocumentModel.Wordprocessing.FieldMapDataImpl(item)).ToList();
          _FieldMapDatas = new ObservableCollection<DocumentModel.Wordprocessing.FieldMapData>(items);
        }
        else
          _FieldMapDatas = new ObservableCollection<DocumentModel.Wordprocessing.FieldMapData>();
        _FieldMapDatas.CollectionChanged += _FieldMapDatas_CollectionChanged;
      }
      return _FieldMapDatas;
    }
    set
    {
      if (value != null && value != _FieldMapDatas && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.FieldMapDataImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.FieldMapData> observableCollection)
        _FieldMapDatas = observableCollection;
      else if (value != null)
        _FieldMapDatas = new ObservableCollection<DocumentModel.Wordprocessing.FieldMapData>(value);
      else
       _FieldMapDatas = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.FieldMapData>? _FieldMapDatas;
  
  private void _FieldMapDatas_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.FieldMapDataImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
        if (val is DocumentModel.Wordprocessing.FieldMapDataImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>()
                          .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
            if (oldItem != null)
              oldItem.Remove();
        };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  public DocumentModel.Wordprocessing.RelationshipType? RecipientDataReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
