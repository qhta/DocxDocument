namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
public class ScatterChartSeries3Impl: ModelElementImpl, ScatterChartSeries3
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ScatterChartSeries3Impl(): base() {}
  
  public ScatterChartSeries3Impl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries openXmlElement): base(openXmlElement)
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.SeriesTextImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.SeriesTextImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ChartShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ChartShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker? Marker
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.MarkerImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.MarkerImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
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
  
  
  public Collection<DocumentModel.Drawings.Charts.ErrorBars>? ErrorBarses
  {
    get
    {
      if (_ErrorBarses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>()
            .Select(item => new DocumentModel.Drawings.Charts.ErrorBarsImpl(item)).ToList();
          _ErrorBarses = new ObservableCollection<DocumentModel.Drawings.Charts.ErrorBars>(items);
        }
        else
          _ErrorBarses = new ObservableCollection<DocumentModel.Drawings.Charts.ErrorBars>();
        _ErrorBarses.CollectionChanged += _ErrorBarses_CollectionChanged;
      }
      return _ErrorBarses;
    }
    set
    {
      if (value != null && value != _ErrorBarses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.ErrorBarsImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.ErrorBars> observableCollection)
        _ErrorBarses = observableCollection;
      else if (value != null)
        _ErrorBarses = new ObservableCollection<DocumentModel.Drawings.Charts.ErrorBars>(value);
      else
       _ErrorBarses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.ErrorBars>? _ErrorBarses;
  
  private void _ErrorBarses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.ErrorBarsImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.ErrorBarsImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>()
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
  
  
  public DocumentModel.Drawings.Charts.XValues? XValues
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.XValues>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.XValuesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.XValues>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.XValuesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.YValues? YValues
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.YValues>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.YValuesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.YValues>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.YValuesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? Smooth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Smooth>();
        return (System.Boolean?)item?.Val?.Value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ScatterSerExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ScatterSerExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
