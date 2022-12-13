namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Surface Charts.
/// </summary>
public class SurfaceChartImpl: ModelElementImpl, SurfaceChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SurfaceChartImpl(): base() {}
  
  public SurfaceChartImpl(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Wireframe.
  /// </summary>
  public Boolean? Wireframe
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Wireframe>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Wireframe>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Wireframe();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.Charts.SurfaceChartSeries>? SurfaceChartSerieses
  {
    get
    {
      if (_SurfaceChartSerieses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries>()
            .Select(item => new DocumentModel.Drawings.Charts.SurfaceChartSeriesImpl(item)).ToList();
          _SurfaceChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.SurfaceChartSeries>(items);
        }
        else
          _SurfaceChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.SurfaceChartSeries>();
        _SurfaceChartSerieses.CollectionChanged += _SurfaceChartSerieses_CollectionChanged;
      }
      return _SurfaceChartSerieses;
    }
    set
    {
      if (value != null && value != _SurfaceChartSerieses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.SurfaceChartSeriesImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.SurfaceChartSeries> observableCollection)
        _SurfaceChartSerieses = observableCollection;
      else if (value != null)
        _SurfaceChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.SurfaceChartSeries>(value);
      else
       _SurfaceChartSerieses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.SurfaceChartSeries>? _SurfaceChartSerieses;
  
  private void _SurfaceChartSerieses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.SurfaceChartSeriesImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.SurfaceChartSeriesImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries>()
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
  
  
  public DocumentModel.Drawings.Charts.BandFormats? BandFormats
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
  
  public DocumentModel.Drawings.Charts.SurfaceChartExtensionList? SurfaceChartExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
