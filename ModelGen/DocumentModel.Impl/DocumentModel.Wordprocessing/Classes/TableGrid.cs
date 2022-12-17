namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
public class TableGridImpl: ModelElementImpl, TableGrid
{
  public DocumentFormat.OpenXml.Wordprocessing.TableGrid? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableGrid?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableGridImpl(): base() {}
  
  public TableGridImpl(DocumentFormat.OpenXml.Wordprocessing.TableGrid openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.GridColumn>? GridColumns
  {
    get
    {
      if (_GridColumns != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.GridColumn>()
            .Select(item => new DocumentModel.Wordprocessing.GridColumnImpl(item)).ToList();
          _GridColumns = new ObservableCollection<DocumentModel.Wordprocessing.GridColumn>(items);
        }
        else
          _GridColumns = new ObservableCollection<DocumentModel.Wordprocessing.GridColumn>();
        _GridColumns.CollectionChanged += _GridColumns_CollectionChanged;
      }
      return _GridColumns;
    }
    set
    {
      if (value != null && value != _GridColumns && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.GridColumn>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.GridColumnImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.GridColumn> observableCollection)
        _GridColumns = observableCollection;
      else if (value != null)
        _GridColumns = new ObservableCollection<DocumentModel.Wordprocessing.GridColumn>(value);
      else
       _GridColumns = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.GridColumn>? _GridColumns;
  
  private void _GridColumns_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.GridColumn>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.GridColumnImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.GridColumnImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.GridColumn>()
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
  
  
  public DocumentModel.Wordprocessing.TableGridChange? TableGridChange
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableGridChange>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableGridChangeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableGridChange>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableGridChangeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
