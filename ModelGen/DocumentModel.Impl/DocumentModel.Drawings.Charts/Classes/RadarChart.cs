namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Radar Charts.
/// </summary>
public class RadarChartImpl: ModelElementImpl, RadarChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.RadarChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RadarChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
      if (_RadarChartSerieses != null)
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
  
  private void _RadarChartSerieses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>();
          break;
        case NotifyCollectionChangedAction.Add:
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
  
  public DocumentModel.Drawings.Charts.RadarChartExtensionList? RadarChartExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
