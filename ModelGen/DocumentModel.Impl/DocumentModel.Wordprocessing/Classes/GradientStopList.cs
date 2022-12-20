namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientStopList Class.
/// </summary>
public partial class GradientStopListImpl: ModelElementImpl, GradientStopList
{
  public DocumentFormat.OpenXml.Office2010.Word.GradientStopList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.GradientStopList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GradientStopListImpl(): base() {}
  
  public GradientStopListImpl(DocumentFormat.OpenXml.Office2010.Word.GradientStopList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.GradientStop>? GradientStops
  {
    get
    {
      if (_GradientStops != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Word.GradientStop>()
            .Select(item => new DocumentModel.Wordprocessing.GradientStopImpl(item)).ToList();
          _GradientStops = new ObservableCollection<DocumentModel.Wordprocessing.GradientStop>(items);
        }
        else
          _GradientStops = new ObservableCollection<DocumentModel.Wordprocessing.GradientStop>();
        _GradientStops.CollectionChanged += _GradientStops_CollectionChanged;
      }
      return _GradientStops;
    }
    set
    {
      if (value != null && value != _GradientStops && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Word.GradientStop>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.GradientStopImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.GradientStop> observableCollection)
        _GradientStops = observableCollection;
      else if (value != null)
        _GradientStops = new ObservableCollection<DocumentModel.Wordprocessing.GradientStop>(value);
      else
       _GradientStops = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.GradientStop>? _GradientStops;
  
  private void _GradientStops_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Word.GradientStop>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.GradientStopImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.GradientStopImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Word.GradientStop>()
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
