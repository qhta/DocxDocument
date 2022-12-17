namespace DocumentModel.Drawings;

/// <summary>
/// Custom Dash.
/// </summary>
public class CustomDashImpl: ModelElementImpl, CustomDash
{
  public DocumentFormat.OpenXml.Drawing.CustomDash? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.CustomDash?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomDashImpl(): base() {}
  
  public CustomDashImpl(DocumentFormat.OpenXml.Drawing.CustomDash openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.DashStop>? DashStops
  {
    get
    {
      if (_DashStops != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.DashStop>()
            .Select(item => new DocumentModel.Drawings.DashStopImpl(item)).ToList();
          _DashStops = new ObservableCollection<DocumentModel.Drawings.DashStop>(items);
        }
        else
          _DashStops = new ObservableCollection<DocumentModel.Drawings.DashStop>();
        _DashStops.CollectionChanged += _DashStops_CollectionChanged;
      }
      return _DashStops;
    }
    set
    {
      if (value != null && value != _DashStops && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.DashStop>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.DashStopImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.DashStop> observableCollection)
        _DashStops = observableCollection;
      else if (value != null)
        _DashStops = new ObservableCollection<DocumentModel.Drawings.DashStop>(value);
      else
       _DashStops = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.DashStop>? _DashStops;
  
  private void _DashStops_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.DashStop>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.DashStopImpl valImpl)
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
              if (val is DocumentModel.Drawings.DashStopImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.DashStop>()
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
  
  
}
