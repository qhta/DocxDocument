namespace DocumentModel.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public partial class SchemaLibraryImpl: ModelElementImpl, SchemaLibrary
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SchemaLibraryImpl(): base() {}
  
  public SchemaLibraryImpl(DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.CustomXml.Schema>? Schemas
  {
    get
    {
      if (_Schemas == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>()
            .Select(item => new DocumentModel.CustomXml.SchemaImpl(item)).ToList();
          _Schemas = new ObservableCollection<DocumentModel.CustomXml.Schema>(items);
        }
        else
          _Schemas = new ObservableCollection<DocumentModel.CustomXml.Schema>();
        _Schemas.CollectionChanged += _Schemas_CollectionChanged;
      }
      return _Schemas;
    }
    set
    {
      if (value != null && value != _Schemas && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>();
        foreach (var val in value)
        {
          if (val is DocumentModel.CustomXml.SchemaImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.CustomXml.Schema> observableCollection)
        _Schemas = observableCollection;
      else if (value != null)
        _Schemas = new ObservableCollection<DocumentModel.CustomXml.Schema>(value);
      else
       _Schemas = null;
    }
  }
  private ObservableCollection<DocumentModel.CustomXml.Schema>? _Schemas;
  
  private void _Schemas_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.CustomXml.SchemaImpl valImpl)
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
              if (val is DocumentModel.CustomXml.SchemaImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>()
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
