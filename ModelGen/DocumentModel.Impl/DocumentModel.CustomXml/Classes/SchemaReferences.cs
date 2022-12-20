namespace DocumentModel.CustomXml;

/// <summary>
/// Set of Associated XML Schemas.
/// </summary>
public partial class SchemaReferencesImpl: ModelElementImpl, SchemaReferences
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SchemaReferencesImpl(): base() {}
  
  public SchemaReferencesImpl(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.CustomXml.SchemaReference>? Items
  {
    get
    {
      if (_Items == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference>()
            .Select(item => new DocumentModel.CustomXml.SchemaReferenceImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.CustomXml.SchemaReference>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.CustomXml.SchemaReference>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference>();
        foreach (var val in value)
        {
          if (val is DocumentModel.CustomXml.SchemaReferenceImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.CustomXml.SchemaReference> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.CustomXml.SchemaReference>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.CustomXml.SchemaReference>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.CustomXml.SchemaReferenceImpl valImpl)
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
              if (val is DocumentModel.CustomXml.SchemaReferenceImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference>()
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
