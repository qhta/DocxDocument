namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public class PlotAreaRegionImpl: ModelElementImpl, PlotAreaRegion
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
  public DocumentModel.Drawings16.Charts.PlotSurface? PlotSurface
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Drawings16.Charts.Series>? Serieses
  {
    get
    {
      if (_Serieses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>()
            .Select(item => new DocumentModel.Drawings16.Charts.SeriesImpl(item)).ToList();
          _Serieses = new ObservableCollection<DocumentModel.Drawings16.Charts.Series>(items);
        }
        else
          _Serieses = new ObservableCollection<DocumentModel.Drawings16.Charts.Series>();
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
        if (val is DocumentModel.Drawings16.Charts.SeriesImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings16.Charts.Series> observableCollection)
        _Serieses = observableCollection;
      else if (value != null)
        _Serieses = new ObservableCollection<DocumentModel.Drawings16.Charts.Series>(value);
      else
       _Serieses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings16.Charts.Series>? _Serieses;
  
  private void _Serieses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings16.Charts.SeriesImpl valImpl)
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
        if (val is DocumentModel.Drawings16.Charts.SeriesImpl valImpl)
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
  
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
