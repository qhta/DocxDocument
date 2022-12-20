namespace DocumentModel.UI;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public partial class TabsImpl: ModelElementImpl, Tabs
{
  public DocumentFormat.OpenXml.Office.CustomUI.Tabs? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.Tabs?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TabsImpl(): base() {}
  
  public TabsImpl(DocumentFormat.OpenXml.Office.CustomUI.Tabs openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.UI.Tab>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.Tab>()
            .Select(item => new DocumentModel.UI.TabImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.UI.Tab>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.UI.Tab>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.Tab>();
        foreach (var val in value)
        {
          if (val is DocumentModel.UI.TabImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.UI.Tab> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.UI.Tab>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.UI.Tab>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.Tab>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.UI.TabImpl valImpl)
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
              if (val is DocumentModel.UI.TabImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.Tab>()
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
