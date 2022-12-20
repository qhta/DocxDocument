namespace DocumentModel;

/// <summary>
/// Defines the ClassificationExtensionList Class.
/// </summary>
public partial class ClassificationExtensionListImpl: ModelElementImpl, ClassificationExtensionList
{
  public DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ClassificationExtensionListImpl(): base() {}
  
  public ClassificationExtensionListImpl(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.ClassificationExtension>? ClassificationExtensions
  {
    get
    {
      if (_ClassificationExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension>()
            .Select(item => new DocumentModel.ClassificationExtensionImpl(item)).ToList();
          _ClassificationExtensions = new ObservableCollection<DocumentModel.ClassificationExtension>(items);
        }
        else
          _ClassificationExtensions = new ObservableCollection<DocumentModel.ClassificationExtension>();
        _ClassificationExtensions.CollectionChanged += _ClassificationExtensions_CollectionChanged;
      }
      return _ClassificationExtensions;
    }
    set
    {
      if (value != null && value != _ClassificationExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.ClassificationExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.ClassificationExtension> observableCollection)
        _ClassificationExtensions = observableCollection;
      else if (value != null)
        _ClassificationExtensions = new ObservableCollection<DocumentModel.ClassificationExtension>(value);
      else
       _ClassificationExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.ClassificationExtension>? _ClassificationExtensions;
  
  private void _ClassificationExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.ClassificationExtensionImpl valImpl)
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
              if (val is DocumentModel.ClassificationExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension>()
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
