namespace DocumentModel.Vml;

/// <summary>
/// Defines the ShapeHandles Class.
/// </summary>
public class ShapeHandlesImpl: ModelElementImpl, ShapeHandles
{
  public DocumentFormat.OpenXml.Vml.ShapeHandles? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.ShapeHandles?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeHandlesImpl(): base() {}
  
  public ShapeHandlesImpl(DocumentFormat.OpenXml.Vml.ShapeHandles openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Vml.ShapeHandle>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.ShapeHandle>()
            .Select(item => new DocumentModel.Vml.ShapeHandleImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Vml.ShapeHandle>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Vml.ShapeHandle>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.ShapeHandle>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Vml.ShapeHandleImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Vml.ShapeHandle> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Vml.ShapeHandle>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Vml.ShapeHandle>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.ShapeHandle>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Vml.ShapeHandleImpl valImpl)
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
              if (val is DocumentModel.Vml.ShapeHandleImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.ShapeHandle>()
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
