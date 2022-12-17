namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtensionList Class.
/// </summary>
public class NonVisualGroupDrawingShapePropsExtensionListImpl: ModelElementImpl, NonVisualGroupDrawingShapePropsExtensionList
{
  public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualGroupDrawingShapePropsExtensionListImpl(): base() {}
  
  public NonVisualGroupDrawingShapePropsExtensionListImpl(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension>? NonVisualGroupDrawingShapePropsExtensions
  {
    get
    {
      if (_NonVisualGroupDrawingShapePropsExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension>()
            .Select(item => new DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionImpl(item)).ToList();
          _NonVisualGroupDrawingShapePropsExtensions = new ObservableCollection<DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension>(items);
        }
        else
          _NonVisualGroupDrawingShapePropsExtensions = new ObservableCollection<DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension>();
        _NonVisualGroupDrawingShapePropsExtensions.CollectionChanged += _NonVisualGroupDrawingShapePropsExtensions_CollectionChanged;
      }
      return _NonVisualGroupDrawingShapePropsExtensions;
    }
    set
    {
      if (value != null && value != _NonVisualGroupDrawingShapePropsExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension> observableCollection)
        _NonVisualGroupDrawingShapePropsExtensions = observableCollection;
      else if (value != null)
        _NonVisualGroupDrawingShapePropsExtensions = new ObservableCollection<DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension>(value);
      else
       _NonVisualGroupDrawingShapePropsExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension>? _NonVisualGroupDrawingShapePropsExtensions;
  
  private void _NonVisualGroupDrawingShapePropsExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension>()
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
