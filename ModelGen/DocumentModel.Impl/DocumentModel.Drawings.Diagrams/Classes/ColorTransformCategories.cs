namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Color Transform Category List.
/// </summary>
public class ColorTransformCategoriesImpl: ModelElementImpl, ColorTransformCategories
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorTransformCategoriesImpl(): base() {}
  
  public ColorTransformCategoriesImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.ColorTransformCategory>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>()
            .Select(item => new DocumentModel.Drawings.Diagrams.ColorTransformCategoryImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformCategory>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformCategory>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.ColorTransformCategoryImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformCategory> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformCategory>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformCategory>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.ColorTransformCategoryImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.ColorTransformCategoryImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>()
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
