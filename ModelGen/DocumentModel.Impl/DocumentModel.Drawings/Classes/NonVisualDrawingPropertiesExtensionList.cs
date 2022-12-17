namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public class NonVisualDrawingPropertiesExtensionListImpl: ModelElementImpl, NonVisualDrawingPropertiesExtensionList
{
  public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualDrawingPropertiesExtensionListImpl(): base() {}
  
  public NonVisualDrawingPropertiesExtensionListImpl(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.NonVisualDrawingPropertiesExtension>? NonVisualDrawingPropertiesExtensions
  {
    get
    {
      if (_NonVisualDrawingPropertiesExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension>()
            .Select(item => new DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionImpl(item)).ToList();
          _NonVisualDrawingPropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.NonVisualDrawingPropertiesExtension>(items);
        }
        else
          _NonVisualDrawingPropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.NonVisualDrawingPropertiesExtension>();
        _NonVisualDrawingPropertiesExtensions.CollectionChanged += _NonVisualDrawingPropertiesExtensions_CollectionChanged;
      }
      return _NonVisualDrawingPropertiesExtensions;
    }
    set
    {
      if (value != null && value != _NonVisualDrawingPropertiesExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.NonVisualDrawingPropertiesExtension> observableCollection)
        _NonVisualDrawingPropertiesExtensions = observableCollection;
      else if (value != null)
        _NonVisualDrawingPropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.NonVisualDrawingPropertiesExtension>(value);
      else
       _NonVisualDrawingPropertiesExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.NonVisualDrawingPropertiesExtension>? _NonVisualDrawingPropertiesExtensions;
  
  private void _NonVisualDrawingPropertiesExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension>()
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
