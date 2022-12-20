namespace DocumentModel;

/// <summary>
/// Defines the ClassificationLabelList Class.
/// </summary>
public partial class ClassificationLabelListImpl: ModelElementImpl, ClassificationLabelList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ClassificationLabelListImpl(): base() {}
  
  public ClassificationLabelListImpl(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.ClassificationLabel>? ClassificationLabels
  {
    get
    {
      if (_ClassificationLabels == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>()
            .Select(item => new DocumentModel.ClassificationLabelImpl(item)).ToList();
          _ClassificationLabels = new ObservableCollection<DocumentModel.ClassificationLabel>(items);
        }
        else
          _ClassificationLabels = new ObservableCollection<DocumentModel.ClassificationLabel>();
        _ClassificationLabels.CollectionChanged += _ClassificationLabels_CollectionChanged;
      }
      return _ClassificationLabels;
    }
    set
    {
      if (value != null && value != _ClassificationLabels && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>();
        foreach (var val in value)
        {
          if (val is DocumentModel.ClassificationLabelImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.ClassificationLabel> observableCollection)
        _ClassificationLabels = observableCollection;
      else if (value != null)
        _ClassificationLabels = new ObservableCollection<DocumentModel.ClassificationLabel>(value);
      else
       _ClassificationLabels = null;
    }
  }
  private ObservableCollection<DocumentModel.ClassificationLabel>? _ClassificationLabels;
  
  private void _ClassificationLabels_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.ClassificationLabelImpl valImpl)
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
              if (val is DocumentModel.ClassificationLabelImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>()
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
  
  
  public DocumentModel.ClassificationExtensionList? ClassificationExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList>();
        if (item != null)
          return new DocumentModel.ClassificationExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ClassificationExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
