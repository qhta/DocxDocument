namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public partial class NonVisualPicturePropertiesExtensionListImpl: ModelElementImpl, NonVisualPicturePropertiesExtensionList
{
  public DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualPicturePropertiesExtensionListImpl(): base() {}
  
  public NonVisualPicturePropertiesExtensionListImpl(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.NonVisualPicturePropertiesExtension>? NonVisualPicturePropertiesExtensions
  {
    get
    {
      if (_NonVisualPicturePropertiesExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension>()
            .Select(item => new DocumentModel.Drawings.NonVisualPicturePropertiesExtensionImpl(item)).ToList();
          _NonVisualPicturePropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.NonVisualPicturePropertiesExtension>(items);
        }
        else
          _NonVisualPicturePropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.NonVisualPicturePropertiesExtension>();
        _NonVisualPicturePropertiesExtensions.CollectionChanged += _NonVisualPicturePropertiesExtensions_CollectionChanged;
      }
      return _NonVisualPicturePropertiesExtensions;
    }
    set
    {
      if (value != null && value != _NonVisualPicturePropertiesExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.NonVisualPicturePropertiesExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.NonVisualPicturePropertiesExtension> observableCollection)
        _NonVisualPicturePropertiesExtensions = observableCollection;
      else if (value != null)
        _NonVisualPicturePropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.NonVisualPicturePropertiesExtension>(value);
      else
       _NonVisualPicturePropertiesExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.NonVisualPicturePropertiesExtension>? _NonVisualPicturePropertiesExtensions;
  
  private void _NonVisualPicturePropertiesExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.NonVisualPicturePropertiesExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.NonVisualPicturePropertiesExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension>()
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
