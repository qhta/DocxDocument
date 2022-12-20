namespace DocumentModel;

/// <summary>
/// Defines the TabSet Class.
/// </summary>
public partial class TabSetImpl: ModelElementImpl, TabSet
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.TabSet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.TabSet?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TabSetImpl(): base() {}
  
  public TabSetImpl(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
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
  /// visible, this property is only available in Office 2010 and later.
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
  /// getVisible, this property is only available in Office 2010 and later.
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
  
  public Collection<DocumentModel.Tab>? Tabs
  {
    get
    {
      if (_Tabs == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>()
            .Select(item => new DocumentModel.TabImpl(item)).ToList();
          _Tabs = new ObservableCollection<DocumentModel.Tab>(items);
        }
        else
          _Tabs = new ObservableCollection<DocumentModel.Tab>();
        _Tabs.CollectionChanged += _Tabs_CollectionChanged;
      }
      return _Tabs;
    }
    set
    {
      if (value != null && value != _Tabs && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>();
        foreach (var val in value)
        {
          if (val is DocumentModel.TabImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Tab> observableCollection)
        _Tabs = observableCollection;
      else if (value != null)
        _Tabs = new ObservableCollection<DocumentModel.Tab>(value);
      else
       _Tabs = null;
    }
  }
  private ObservableCollection<DocumentModel.Tab>? _Tabs;
  
  private void _Tabs_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.TabImpl valImpl)
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
              if (val is DocumentModel.TabImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>()
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
