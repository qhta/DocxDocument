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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public UInt16? GapWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapWidth>();
        return (System.UInt16?)openXmlElement?.Val?.Value;
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Overlap>();
        return (System.SByte?)openXmlElement?.Val?.Value;
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
  
  
  public UInt32? AxisId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AxisId>();
        return (System.UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AxisId>();
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
            item = new DocumentFormat.OpenXml.Drawing.Charts.AxisId{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.BarChartExtensionList? BarChartExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
