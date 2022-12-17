namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Bar Charts.
/// </summary>
public class BarChartImpl: ModelElementImpl, BarChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.BarChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BarChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BarChartImpl(): base() {}
  
  public BarChartImpl(DocumentFormat.OpenXml.Drawing.Charts.BarChart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarDirectionKind? BarDirection
  {
    get => (DocumentModel.Drawings.Charts.BarDirectionKind?)OpenXmlElement?.BarDirection?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.BarDirection != null)
        {
          if (value is not null)
            OpenXmlElement.BarDirection.Val = (DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues?)value;
          else
            OpenXmlElement.BarDirection = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.BarDirection = new DocumentFormat.OpenXml.Drawing.Charts.BarDirection{ Val = (DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarGroupingKind? BarGrouping
  {
    get => (DocumentModel.Drawings.Charts.BarGroupingKind?)OpenXmlElement?.BarGrouping?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.BarGrouping != null)
        {
          if (value is not null)
            OpenXmlElement.BarGrouping.Val = (DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues?)value;
          else
            OpenXmlElement.BarGrouping = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.BarGrouping = new DocumentFormat.OpenXml.Drawing.Charts.BarGrouping{ Val = (DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.VaryColors();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.Charts.BarChartSeries>? BarChartSerieses
  {
    get
    {
      if (_BarChartSerieses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries>()
            .Select(item => new DocumentModel.Drawings.Charts.BarChartSeriesImpl(item)).ToList();
          _BarChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.BarChartSeries>(items);
        }
        else
          _BarChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.BarChartSeries>();
        _BarChartSerieses.CollectionChanged += _BarChartSerieses_CollectionChanged;
      }
      return _BarChartSerieses;
    }
    set
    {
      if (value != null && value != _BarChartSerieses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.BarChartSeriesImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.BarChartSeries> observableCollection)
        _BarChartSerieses = observableCollection;
      else if (value != null)
        _BarChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.BarChartSeries>(value);
      else
       _BarChartSerieses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.BarChartSeries>? _BarChartSerieses;
  
  private void _BarChartSerieses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.BarChartSeriesImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.BarChartSeriesImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries>()
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
  
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.DataLabelsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.DataLabelsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public UInt16? GapWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapWidth>();
        return (System.UInt16?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapWidth>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt16?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.GapWidth{ Val = (System.UInt16?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public SByte? Overlap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Overlap>();
        return (System.SByte?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Overlap>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.SByte?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Overlap{ Val = (System.SByte?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.Charts.SeriesLines>? SeriesLineses
  {
    get
    {
      if (_SeriesLineses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>()
            .Select(item => new DocumentModel.Drawings.Charts.SeriesLinesImpl(item)).ToList();
          _SeriesLineses = new ObservableCollection<DocumentModel.Drawings.Charts.SeriesLines>(items);
        }
        else
          _SeriesLineses = new ObservableCollection<DocumentModel.Drawings.Charts.SeriesLines>();
        _SeriesLineses.CollectionChanged += _SeriesLineses_CollectionChanged;
      }
      return _SeriesLineses;
    }
    set
    {
      if (value != null && value != _SeriesLineses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.SeriesLinesImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.SeriesLines> observableCollection)
        _SeriesLineses = observableCollection;
      else if (value != null)
        _SeriesLineses = new ObservableCollection<DocumentModel.Drawings.Charts.SeriesLines>(value);
      else
       _SeriesLineses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.SeriesLines>? _SeriesLineses;
  
  private void _SeriesLineses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.SeriesLinesImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.SeriesLinesImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>()
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
  
  
  public Collection<System.UInt32>? AxisIds
  {
    get
    {
      if (_AxisIds != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AxisId>()
            .Select(item => item.Val?.Value ?? default).ToList();
          _AxisIds = new ObservableCollection<System.UInt32>(items);
        }
        else
          _AxisIds = new ObservableCollection<System.UInt32>();
        _AxisIds.CollectionChanged += _AxisIds_CollectionChanged;
      }
      return _AxisIds;
    }
    set
    {
      if (value != null && value != _AxisIds && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AxisId>();
        foreach (var val in value)
        {
          var item = new DocumentFormat.OpenXml.Drawing.Charts.AxisId{ Val = val };
          OpenXmlElement.AddChild(item);
        }
      }
      if (value is ObservableCollection<System.UInt32> observableCollection)
        _AxisIds = observableCollection;
      else if (value != null)
        _AxisIds = new ObservableCollection<System.UInt32>(value);
      else
       _AxisIds = null;
    }
  }
  private ObservableCollection<System.UInt32>? _AxisIds;
  
  private void _AxisIds_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AxisId>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            var newItem = new DocumentFormat.OpenXml.Drawing.Charts.AxisId { Val = (UInt32)val };
            OpenXmlElement.AddChild(newItem);
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AxisId>()
                          .FirstOrDefault(anItem => anItem.Val?.Value == (UInt32)val);
            if (oldItem != null)
              oldItem.Remove();
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  public DocumentModel.Drawings.Charts.BarChartExtensionList? BarChartExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.BarChartExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.BarChartExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
