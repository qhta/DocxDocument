namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtensionList Class.
/// </summary>
public partial class ShapePropertiesExtensionListImpl: ModelElementImpl, ShapePropertiesExtensionList
{
  public DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapePropertiesExtensionListImpl(): base() {}
  
  public ShapePropertiesExtensionListImpl(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.ShapePropertiesExtension>? ShapePropertiesExtensions
  {
    get
    {
      if (_ShapePropertiesExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>()
            .Select(item => new DocumentModel.Drawings.ShapePropertiesExtensionImpl(item)).ToList();
          _ShapePropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.ShapePropertiesExtension>(items);
        }
        else
          _ShapePropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.ShapePropertiesExtension>();
        _ShapePropertiesExtensions.CollectionChanged += _ShapePropertiesExtensions_CollectionChanged;
      }
      return _ShapePropertiesExtensions;
    }
    set
    {
      if (value != null && value != _ShapePropertiesExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ShapePropertiesExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ShapePropertiesExtension> observableCollection)
        _ShapePropertiesExtensions = observableCollection;
      else if (value != null)
        _ShapePropertiesExtensions = new ObservableCollection<DocumentModel.Drawings.ShapePropertiesExtension>(value);
      else
       _ShapePropertiesExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ShapePropertiesExtension>? _ShapePropertiesExtensions;
  
  private void _ShapePropertiesExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ShapePropertiesExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.ShapePropertiesExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>()
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
