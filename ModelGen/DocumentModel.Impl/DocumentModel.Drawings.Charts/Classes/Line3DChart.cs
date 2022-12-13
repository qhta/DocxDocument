namespace DocumentModel.Drawings.Charts;

/// <summary>
/// 3D Line Charts.
/// </summary>
public class Line3DChartImpl: ModelElementImpl, Line3DChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Line3DChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Line3DChartImpl(): base() {}
  
  public Line3DChartImpl(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement): base(openXmlElement)
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
  
  public Collection<DocumentModel.Drawings.Charts.LineChartSeries>? LineChartSerieses
  {
    get
    {
      if (_LineChartSerieses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>()
            .Select(item => new DocumentModel.Drawings.Charts.LineChartSeriesImpl(item)).ToList();
          _LineChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.LineChartSeries>(items);
        }
        else
          _LineChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.LineChartSeries>();
        _LineChartSerieses.CollectionChanged += _LineChartSerieses_CollectionChanged;
      }
      return _LineChartSerieses;
    }
    set
    {
      if (value != null && value != _LineChartSerieses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.LineChartSeriesImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.LineChartSeries> observableCollection)
        _LineChartSerieses = observableCollection;
      else if (value != null)
        _LineChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.LineChartSeries>(value);
      else
       _LineChartSerieses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.LineChartSeries>? _LineChartSerieses;
  
  private void _LineChartSerieses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.LineChartSeriesImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.LineChartSeriesImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>()
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
  
  public DocumentModel.Drawings.Charts.DropLines? DropLines
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public UInt16? GapDepth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapDepth>();
        return (System.UInt16?)openXmlElement?.Val?.Value;
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
  
  public DocumentModel.Drawings.Charts.Line3DChartExtensionList? Line3DChartExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
