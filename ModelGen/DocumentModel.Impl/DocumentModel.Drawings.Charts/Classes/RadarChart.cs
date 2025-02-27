namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Radar Charts.
/// </summary>
public partial class RadarChartImpl: ModelElementImpl, RadarChart
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.RadarChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RadarChart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RadarChartImpl(): base() {}
  
  public RadarChartImpl(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public DocumentModel.Drawings.Charts.RadarStyleKind? RadarStyle
  {
    get => (DocumentModel.Drawings.Charts.RadarStyleKind?)OpenXmlElement?.RadarStyle?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RadarStyle != null)
        {
          if (value is not null)
            OpenXmlElement.RadarStyle.Val = (DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues?)value;
          else
            OpenXmlElement.RadarStyle = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RadarStyle = new DocumentFormat.OpenXml.Drawing.Charts.RadarStyle{ Val = (DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues?)value };
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
  
  public Collection<DocumentModel.Drawings.Charts.RadarChartSeries>? RadarChartSerieses
  {
    get
    {
      if (_RadarChartSerieses == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>()
            .Select(item => new DocumentModel.Drawings.Charts.RadarChartSeriesImpl(item)).ToList();
          _RadarChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.RadarChartSeries>(items);
        }
        else
          _RadarChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.RadarChartSeries>();
        _RadarChartSerieses.CollectionChanged += _RadarChartSerieses_CollectionChanged;
      }
      return _RadarChartSerieses;
    }
    set
    {
      if (value != null && value != _RadarChartSerieses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.RadarChartSeriesImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.RadarChartSeries> observableCollection)
        _RadarChartSerieses = observableCollection;
      else if (value != null)
        _RadarChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.RadarChartSeries>(value);
      else
       _RadarChartSerieses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.RadarChartSeries>? _RadarChartSerieses;
  
  private void _RadarChartSerieses_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.RadarChartSeriesImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Drawings.Charts.RadarChartSeriesImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>()
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
  
  public Collection<System.UInt32>? AxisIds
  {
    get
    {
      if (_AxisIds == null)
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
  
  private void _AxisIds_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AxisId>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            var newItem = new DocumentFormat.OpenXml.Drawing.Charts.AxisId { Val = (UInt32)val };
            OpenXmlElement.AddChild(newItem);
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
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
  
  
  public DocumentModel.Drawings.Charts.RadarChartExtensionList? RadarChartExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.RadarChartExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.RadarChartExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
