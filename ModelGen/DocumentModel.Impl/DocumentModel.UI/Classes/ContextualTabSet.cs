namespace DocumentModel.UI;

/// <summary>
/// Defines the ContextualTabSet Class.
/// </summary>
public partial class ContextualTabSetImpl: ModelElementImpl, ContextualTabSet
{
  public DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ContextualTabSetImpl(): base() {}
  
  public ContextualTabSetImpl(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  public String? IdMso
  {
    get => (System.String?)OpenXmlElement?.IdMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IdMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public Boolean? Visible
  {
    get => (System.Boolean?)OpenXmlElement?.Visible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Visible = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public String? GetVisible
  {
    get => (System.String?)OpenXmlElement?.GetVisible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetVisible = (System.String?)value;
    }
  }
  
  public Collection<DocumentModel.UI.Tab>? Tabs
  {
    get
    {
      if (_Tabs != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.Tab>()
            .Select(item => new DocumentModel.UI.TabImpl(item)).ToList();
          _Tabs = new ObservableCollection<DocumentModel.UI.Tab>(items);
        }
        else
          _Tabs = new ObservableCollection<DocumentModel.UI.Tab>();
        _Tabs.CollectionChanged += _Tabs_CollectionChanged;
      }
      return _Tabs;
    }
    set
    {
      if (value != null && value != _Tabs && OpenXmlElement!=null)
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
        _Tabs = observableCollection;
      else if (value != null)
        _Tabs = new ObservableCollection<DocumentModel.UI.Tab>(value);
      else
       _Tabs = null;
    }
  }
  private ObservableCollection<DocumentModel.UI.Tab>? _Tabs;
  
  private void _Tabs_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
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
