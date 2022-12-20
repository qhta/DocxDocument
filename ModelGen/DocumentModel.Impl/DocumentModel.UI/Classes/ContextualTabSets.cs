namespace DocumentModel.UI;

/// <summary>
/// Defines the ContextualTabSets Class.
/// </summary>
public partial class ContextualTabSetsImpl: ModelElementImpl, ContextualTabSets
{
  public DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ContextualTabSetsImpl(): base() {}
  
  public ContextualTabSetsImpl(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.UI.ContextualTabSet>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>()
            .Select(item => new DocumentModel.UI.ContextualTabSetImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.UI.ContextualTabSet>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.UI.ContextualTabSet>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>();
        foreach (var val in value)
        {
          if (val is DocumentModel.UI.ContextualTabSetImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.UI.ContextualTabSet> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.UI.ContextualTabSet>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.UI.ContextualTabSet>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.UI.ContextualTabSetImpl valImpl)
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
              if (val is DocumentModel.UI.ContextualTabSetImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>()
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
