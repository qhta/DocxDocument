namespace DocumentModel.Drawings.Charts;

/// <summary>
/// 3D Area Charts.
/// </summary>
public class Area3DChartImpl: ModelElementImpl, Area3DChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.Area3DChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Area3DChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Area3DChartImpl(): base() {}
  
  public Area3DChartImpl(DocumentFormat.OpenXml.Drawing.Charts.Area3DChart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.GroupingKind? Grouping
  {
    get => (DocumentModel.Drawings.Charts.GroupingKind?)OpenXmlElement?.Grouping?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Grouping != null)
        {
          if (value is not null)
            OpenXmlElement.Grouping.Val = (DocumentFormat.OpenXml.Drawing.Charts.GroupingValues?)value;
          else
            OpenXmlElement.Grouping = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Grouping = new DocumentFormat.OpenXml.Drawing.Charts.Grouping{ Val = (DocumentFormat.OpenXml.Drawing.Charts.GroupingValues?)value };
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
  
  public Collection<DocumentModel.Drawings.Charts.AreaChartSeries>? AreaChartSerieses
  {
    get
    {
      if (_AreaChartSerieses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AreaChartSeries>()
            .Select(item => new DocumentModel.Drawings.Charts.AreaChartSeriesImpl(item)).ToList();
          _AreaChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.AreaChartSeries>(items);
        }
        else
          _AreaChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.AreaChartSeries>();
        _AreaChartSerieses.CollectionChanged += _AreaChartSerieses_CollectionChanged;
      }
      return _AreaChartSerieses;
    }
    set
    {
      if (value != null && value != _AreaChartSerieses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AreaChartSeries>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.AreaChartSeriesImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.AreaChartSeries> observableCollection)
        _AreaChartSerieses = observableCollection;
      else if (value != null)
        _AreaChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.AreaChartSeries>(value);
      else
       _AreaChartSerieses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.AreaChartSeries>? _AreaChartSerieses;
  
  private void _AreaChartSerieses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AreaChartSeries>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.AreaChartSeriesImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.AreaChartSeriesImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AreaChartSeries>()
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
  
  public DocumentModel.Drawings.Charts.DropLines? DropLines
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DropLines>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.DropLinesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DropLines>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.DropLinesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public UInt16? GapDepth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapDepth>();
        return (System.UInt16?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapDepth>();
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
            item = new DocumentFormat.OpenXml.Drawing.Charts.GapDepth{ Val = (System.UInt16?)value };
            OpenXmlElement.AddChild(item);
          }
        }
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
  
  
  public DocumentModel.Drawings.Charts.Area3DChartExtensionList? Area3DChartExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.Area3DChartExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.Area3DChartExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
