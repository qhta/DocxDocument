namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
public class ScatterChartSeriesImpl: ModelElementImpl, ScatterChartSeries
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ScatterChartSeriesImpl(): base() {}
  
  public ScatterChartSeriesImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index
  {
    get => (System.UInt32?)OpenXmlElement?.Index?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Index != null)
        {
          if (value is not null)
            OpenXmlElement.Index.Val = (System.UInt32?)value;
          else
            OpenXmlElement.Index = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Index = new DocumentFormat.OpenXml.Drawing.Charts.Index{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  public UInt32? Order
  {
    get => (System.UInt32?)OpenXmlElement?.Order?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Order != null)
        {
          if (value is not null)
            OpenXmlElement.Order.Val = (System.UInt32?)value;
          else
            OpenXmlElement.Order = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Order = new DocumentFormat.OpenXml.Drawing.Charts.Order{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public DocumentModel.Drawings.Charts.SeriesText? SeriesText
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker? Marker
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Drawings.Charts.DataPoint>? DataPoints
  {
    get
    {
      if (_DataPoints != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>()
            .Select(item => new DocumentModel.Drawings.Charts.DataPointImpl(item)).ToList();
          _DataPoints = new ObservableCollection<DocumentModel.Drawings.Charts.DataPoint>(items);
        }
        else
          _DataPoints = new ObservableCollection<DocumentModel.Drawings.Charts.DataPoint>();
        _DataPoints.CollectionChanged += _DataPoints_CollectionChanged;
      }
      return _DataPoints;
    }
    set
    {
      if (value != null && value != _DataPoints && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.DataPointImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.DataPoint> observableCollection)
        _DataPoints = observableCollection;
      else if (value != null)
        _DataPoints = new ObservableCollection<DocumentModel.Drawings.Charts.DataPoint>(value);
      else
       _DataPoints = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.DataPoint>? _DataPoints;
  
  private void _DataPoints_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.DataPointImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.DataPointImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>()
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
  
  public Collection<DocumentModel.Drawings.Charts.Trendline>? Trendlines
  {
    get
    {
      if (_Trendlines != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Trendline>()
            .Select(item => new DocumentModel.Drawings.Charts.TrendlineImpl(item)).ToList();
          _Trendlines = new ObservableCollection<DocumentModel.Drawings.Charts.Trendline>(items);
        }
        else
          _Trendlines = new ObservableCollection<DocumentModel.Drawings.Charts.Trendline>();
        _Trendlines.CollectionChanged += _Trendlines_CollectionChanged;
      }
      return _Trendlines;
    }
    set
    {
      if (value != null && value != _Trendlines && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Trendline>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.TrendlineImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.Trendline> observableCollection)
        _Trendlines = observableCollection;
      else if (value != null)
        _Trendlines = new ObservableCollection<DocumentModel.Drawings.Charts.Trendline>(value);
      else
       _Trendlines = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.Trendline>? _Trendlines;
  
  private void _Trendlines_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Trendline>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.TrendlineImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.TrendlineImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Trendline>()
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
  
  
  public DocumentModel.Drawings.Charts.ErrorBars? ErrorBars
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.XValues? XValues
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.YValues? YValues
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Boolean? Smooth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Smooth>();
        return (System.Boolean?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Smooth>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Smooth{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.ScatterSerExtensionList? ScatterSerExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
