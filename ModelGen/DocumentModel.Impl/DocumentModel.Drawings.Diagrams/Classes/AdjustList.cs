namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Shape Adjust List.
/// </summary>
public class AdjustListImpl: ModelElementImpl, AdjustList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AdjustListImpl(): base() {}
  
  public AdjustListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.Adjust>? Adjusts
  {
    get
    {
      if (_Adjusts != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>()
            .Select(item => new DocumentModel.Drawings.Diagrams.AdjustImpl(item)).ToList();
          _Adjusts = new ObservableCollection<DocumentModel.Drawings.Diagrams.Adjust>(items);
        }
        else
          _Adjusts = new ObservableCollection<DocumentModel.Drawings.Diagrams.Adjust>();
        _Adjusts.CollectionChanged += _Adjusts_CollectionChanged;
      }
      return _Adjusts;
    }
    set
    {
      if (value != null && value != _Adjusts && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Diagrams.AdjustImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.Adjust> observableCollection)
        _Adjusts = observableCollection;
      else if (value != null)
        _Adjusts = new ObservableCollection<DocumentModel.Drawings.Diagrams.Adjust>(value);
      else
       _Adjusts = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.Adjust>? _Adjusts;
  
  private void _Adjusts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Diagrams.AdjustImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.AdjustImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>()
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
