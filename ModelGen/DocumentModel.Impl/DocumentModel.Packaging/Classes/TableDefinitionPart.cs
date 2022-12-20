namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TableDefinitionPart
/// </summary>
public partial class TableDefinitionPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, TableDefinitionPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.TableDefinitionPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.TableDefinitionPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TableDefinitionPartImpl(): base() {}
  
  public TableDefinitionPartImpl(DocumentFormat.OpenXml.Packaging.TableDefinitionPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public Collection<DocumentModel.Packaging.QueryTablePart>? QueryTableParts
  {
    get
    {
      if (_QueryTableParts == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.QueryTablePart>()
            .Select(item => new DocumentModel.Packaging.QueryTablePartImpl(item)).ToList();
          _QueryTableParts = new ObservableCollection<DocumentModel.Packaging.QueryTablePart>(items);
        }
        else
          _QueryTableParts = new ObservableCollection<DocumentModel.Packaging.QueryTablePart>();
        _QueryTableParts.CollectionChanged += _QueryTableParts_CollectionChanged;
      }
      return _QueryTableParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.QueryTablePart>? _QueryTableParts;
  
  private void _QueryTableParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.QueryTablePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.QueryTablePartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.QueryTablePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.QueryTablePart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
