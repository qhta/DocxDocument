namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public class PlotAreaImpl: ModelElementImpl, PlotArea
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PlotAreaImpl(): base() {}
  
  public PlotAreaImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// PlotAreaRegion.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PlotAreaRegion? PlotAreaRegion
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Drawings16.Charts.Axis>? Axises
  {
    get
    {
      if (_Axises != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis>()
            .Select(item => new DocumentModel.Drawings16.Charts.AxisImpl(item)).ToList();
          _Axises = new ObservableCollection<DocumentModel.Drawings16.Charts.Axis>(items);
        }
        else
          _Axises = new ObservableCollection<DocumentModel.Drawings16.Charts.Axis>();
        _Axises.CollectionChanged += _Axises_CollectionChanged;
      }
      return _Axises;
    }
    set
    {
      if (value != null && value != _Axises && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings16.Charts.AxisImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings16.Charts.Axis> observableCollection)
        _Axises = observableCollection;
      else if (value != null)
        _Axises = new ObservableCollection<DocumentModel.Drawings16.Charts.Axis>(value);
      else
       _Axises = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings16.Charts.Axis>? _Axises;
  
  private void _Axises_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings16.Charts.AxisImpl valImpl)
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
        if (val is DocumentModel.Drawings16.Charts.AxisImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis>()
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
  
  
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
