namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public partial class PlotAreaRegionImpl: ModelElementImpl, PlotAreaRegion
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PlotAreaRegionImpl(): base() {}
  
  public PlotAreaRegionImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.PlotSurface? PlotSurface
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.PlotSurfaceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.PlotSurfaceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.Series>? Serieses
  {
    get
    {
      if (_Serieses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.SeriesImpl(item)).ToList();
          _Serieses = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.Series>(items);
        }
        else
          _Serieses = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.Series>();
        _Serieses.CollectionChanged += _Serieses_CollectionChanged;
      }
      return _Serieses;
    }
    set
    {
      if (value != null && value != _Serieses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ChartDrawings.SeriesImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.Series> observableCollection)
        _Serieses = observableCollection;
      else if (value != null)
        _Serieses = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.Series>(value);
      else
       _Serieses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.Series>? _Serieses;
  
  private void _Serieses_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ChartDrawings.SeriesImpl valImpl)
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
              if (val is DocumentModel.Drawings.ChartDrawings.SeriesImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>()
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
  
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
