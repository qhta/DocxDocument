namespace DocumentModel.Vml;

/// <summary>
/// Shape Grouping History.
/// </summary>
public partial class RegroupTableImpl: ModelElementImpl, RegroupTable
{
  public DocumentFormat.OpenXml.Vml.Office.RegroupTable? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.RegroupTable?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RegroupTableImpl(): base() {}
  
  public RegroupTableImpl(DocumentFormat.OpenXml.Vml.Office.RegroupTable openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  public Collection<DocumentModel.Vml.Entry>? Entries
  {
    get
    {
      if (_Entries != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Entry>()
            .Select(item => new DocumentModel.Vml.EntryImpl(item)).ToList();
          _Entries = new ObservableCollection<DocumentModel.Vml.Entry>(items);
        }
        else
          _Entries = new ObservableCollection<DocumentModel.Vml.Entry>();
        _Entries.CollectionChanged += _Entries_CollectionChanged;
      }
      return _Entries;
    }
    set
    {
      if (value != null && value != _Entries && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Entry>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Vml.EntryImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Vml.Entry> observableCollection)
        _Entries = observableCollection;
      else if (value != null)
        _Entries = new ObservableCollection<DocumentModel.Vml.Entry>(value);
      else
       _Entries = null;
    }
  }
  private ObservableCollection<DocumentModel.Vml.Entry>? _Entries;
  
  private void _Entries_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Entry>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Vml.EntryImpl valImpl)
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
              if (val is DocumentModel.Vml.EntryImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Entry>()
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
