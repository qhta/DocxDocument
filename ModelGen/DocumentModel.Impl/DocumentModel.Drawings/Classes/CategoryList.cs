namespace DocumentModel.Drawings;

/// <summary>
/// Category List.
/// </summary>
public class CategoryListImpl: ModelElementImpl, CategoryList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CategoryListImpl(): base() {}
  
  public CategoryListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Category>? Categories
  {
    get
    {
      if (_Categories != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Category>()
            .Select(item => new DocumentModel.Drawings.CategoryImpl(item)).ToList();
          _Categories = new ObservableCollection<DocumentModel.Drawings.Category>(items);
        }
        else
          _Categories = new ObservableCollection<DocumentModel.Drawings.Category>();
        _Categories.CollectionChanged += _Categories_CollectionChanged;
      }
      return _Categories;
    }
    set
    {
      if (value != null && value != _Categories && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Category>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.CategoryImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Category> observableCollection)
        _Categories = observableCollection;
      else if (value != null)
        _Categories = new ObservableCollection<DocumentModel.Drawings.Category>(value);
      else
       _Categories = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Category>? _Categories;
  
  private void _Categories_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Category>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.CategoryImpl valImpl)
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
        if (val is DocumentModel.Drawings.CategoryImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Category>()
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
