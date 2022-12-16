namespace DocumentModel.Drawings.ChartDrawings;

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
  public DocumentModel.Drawings.ChartDrawings.SeriesLayout? LayoutId
  {
    get => (DocumentModel.Drawings.ChartDrawings.SeriesLayout?)OpenXmlElement?.LayoutId?.Value;
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
  public DocumentModel.Drawings.ChartDrawings.Text? Text
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.TextImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.TextImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ValueColors? ValueColors
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ValueColorsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ValueColorsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ValueColorPositions? ValueColorPositions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ValueColorPositionsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ValueColorPositionsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.DataPoint>? DataPoints
  {
    get
    {
      if (_DataPoints != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.DataPointImpl(item)).ToList();
          _DataPoints = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataPoint>(items);
        }
        else
          _DataPoints = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataPoint>();
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
        if (val is DocumentModel.Drawings.ChartDrawings.DataPointImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataPoint> observableCollection)
        _DataPoints = observableCollection;
      else if (value != null)
        _DataPoints = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataPoint>(value);
      else
       _DataPoints = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataPoint>? _DataPoints;
  
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
          if (val is DocumentModel.Drawings.ChartDrawings.DataPointImpl valImpl)
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
        if (val is DocumentModel.Drawings.ChartDrawings.DataPointImpl valImpl)
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
  
  
  public DocumentModel.Drawings.ChartDrawings.DataLabels? DataLabels
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.DataLabelsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.DataLabelsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public UInt32? DataId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId>();
        return (System.UInt32?)item?.Val?.Value;
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
  
  public DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? SeriesLayoutProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.SeriesLayoutPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.SeriesLayoutPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
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
  
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
