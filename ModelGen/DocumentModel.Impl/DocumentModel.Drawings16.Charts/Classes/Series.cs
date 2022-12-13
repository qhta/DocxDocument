namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Series Class.
/// </summary>
public class SeriesImpl: ModelElementImpl, Series
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SeriesImpl(): base() {}
  
  public SeriesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.SeriesLayout? LayoutId
  {
    get => (DocumentModel.Drawings16.Charts.SeriesLayout?)OpenXmlElement?.LayoutId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LayoutId = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout?)value;
    }
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Hidden
  {
    get => (System.Boolean?)OpenXmlElement?.Hidden?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hidden = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? OwnerIdx
  {
    get => (System.UInt32?)OpenXmlElement?.OwnerIdx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OwnerIdx = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? UniqueId
  {
    get => (System.String?)OpenXmlElement?.UniqueId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UniqueId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? FormatIdx
  {
    get => (System.UInt32?)OpenXmlElement?.FormatIdx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FormatIdx = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Drawings16.Charts.Text? Text
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ValueColors? ValueColors
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ValueColorPositions? ValueColorPositions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Drawings16.Charts.DataPoint>? DataPoints
  {
    get
    {
      if (_DataPoints != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>()
            .Select(item => new DocumentModel.Drawings16.Charts.DataPointImpl(item)).ToList();
          _DataPoints = new ObservableCollection<DocumentModel.Drawings16.Charts.DataPoint>(items);
        }
        else
          _DataPoints = new ObservableCollection<DocumentModel.Drawings16.Charts.DataPoint>();
        _DataPoints.CollectionChanged += _DataPoints_CollectionChanged;
      }
      return _DataPoints;
    }
    set
    {
      if (value != null && value != _DataPoints && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings16.Charts.DataPointImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings16.Charts.DataPoint> observableCollection)
        _DataPoints = observableCollection;
      else if (value != null)
        _DataPoints = new ObservableCollection<DocumentModel.Drawings16.Charts.DataPoint>(value);
      else
       _DataPoints = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings16.Charts.DataPoint>? _DataPoints;
  
  private void _DataPoints_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings16.Charts.DataPointImpl valImpl)
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
        if (val is DocumentModel.Drawings16.Charts.DataPointImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>()
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
  
  
  public DocumentModel.Drawings16.Charts.DataLabels? DataLabels
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public UInt32? DataId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId>();
        return (System.UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings16.Charts.SeriesLayoutProperties? SeriesLayoutProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<System.String>? AxisIds
  {
    get
    {
      if (_AxisIds != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId>()
            .Select(item => item.Text).ToList();
          _AxisIds = new ObservableCollection<System.String>(items);
        }
        else
          _AxisIds = new ObservableCollection<System.String>();
        _AxisIds.CollectionChanged += _AxisIds_CollectionChanged;
      }
      return _AxisIds;
    }
    set
    {
      if (value != null && value != _AxisIds && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId>();
        foreach (var val in value)
        {
        if (val is string str)
        {
          var item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId{ Text = str };
          OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<System.String> observableCollection)
        _AxisIds = observableCollection;
      else if (value != null)
        _AxisIds = new ObservableCollection<System.String>(value);
      else
       _AxisIds = null;
    }
  }
  private ObservableCollection<System.String>? _AxisIds;
  
  private void _AxisIds_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is string str)
          {
            var newItem = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId { Text = str };
            OpenXmlElement.AddChild(newItem);
          };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
        if (val is string str)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId>()
                          .FirstOrDefault(anItem => anItem.Text == str);
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
  
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
