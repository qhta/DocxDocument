namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
public class ScatterChartImpl: ModelElementImpl, ScatterChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ScatterChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ScatterChartImpl(): base() {}
  
  public ScatterChartImpl(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public DocumentModel.Drawings.Charts.ScatterStyleKind? ScatterStyle
  {
    get => (DocumentModel.Drawings.Charts.ScatterStyleKind?)OpenXmlElement?.ScatterStyle?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ScatterStyle != null)
        {
          if (value is not null)
            OpenXmlElement.ScatterStyle.Val = (DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues?)value;
          else
            OpenXmlElement.ScatterStyle = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ScatterStyle = new DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle{ Val = (DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues?)value };
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
  
  public Collection<DocumentModel.Drawings.Charts.ScatterChartSeries>? ScatterChartSerieses
  {
    get
    {
      if (_ScatterChartSerieses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>()
            .Select(item => new DocumentModel.Drawings.Charts.ScatterChartSeriesImpl(item)).ToList();
          _ScatterChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.ScatterChartSeries>(items);
        }
        else
          _ScatterChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.ScatterChartSeries>();
        _ScatterChartSerieses.CollectionChanged += _ScatterChartSerieses_CollectionChanged;
      }
      return _ScatterChartSerieses;
    }
    set
    {
      if (value != null && value != _ScatterChartSerieses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.ScatterChartSeriesImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.ScatterChartSeries> observableCollection)
        _ScatterChartSerieses = observableCollection;
      else if (value != null)
        _ScatterChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.ScatterChartSeries>(value);
      else
       _ScatterChartSerieses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.ScatterChartSeries>? _ScatterChartSerieses;
  
  private void _ScatterChartSerieses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.ScatterChartSeriesImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.ScatterChartSeriesImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>()
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
  
  public DocumentModel.Drawings.Charts.ScatterChartExtensionList? ScatterChartExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
