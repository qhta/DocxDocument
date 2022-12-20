namespace DocumentModel;

/// <summary>
/// Defines the ContextualTabs Class.
/// </summary>
public partial class ContextualTabsImpl: ModelElementImpl, ContextualTabs
{
  public DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ContextualTabsImpl(): base() {}
  
  public ContextualTabsImpl(DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.TabSet>? TabSets
  {
    get
    {
      if (_TabSets != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>()
            .Select(item => new DocumentModel.TabSetImpl(item)).ToList();
          _TabSets = new ObservableCollection<DocumentModel.TabSet>(items);
        }
        else
          _TabSets = new ObservableCollection<DocumentModel.TabSet>();
        _TabSets.CollectionChanged += _TabSets_CollectionChanged;
      }
      return _TabSets;
    }
    set
    {
      if (value != null && value != _TabSets && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>();
        foreach (var val in value)
        {
          if (val is DocumentModel.TabSetImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.TabSet> observableCollection)
        _TabSets = observableCollection;
      else if (value != null)
        _TabSets = new ObservableCollection<DocumentModel.TabSet>(value);
      else
       _TabSets = null;
    }
  }
  private ObservableCollection<DocumentModel.TabSet>? _TabSets;
  
  private void _TabSets_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.TabSetImpl valImpl)
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
              if (val is DocumentModel.TabSetImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>()
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
