namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Grid.
/// </summary>
public partial class PreviousTableGridImpl: ModelElementImpl, PreviousTableGrid
{
  public DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PreviousTableGridImpl(): base() {}
  
  public PreviousTableGridImpl(DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid openXmlElement): base(openXmlElement)
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
  
  private void _GridColumns_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.GridColumn>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
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
          if (args.OldItems != null)
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
  
  
}
