namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapCustomizations Class.
/// </summary>
public partial class KeyMapCustomizationsImpl: ModelElementImpl, KeyMapCustomizations
{
  public DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public KeyMapCustomizationsImpl(): base() {}
  
  public KeyMapCustomizationsImpl(DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.KeyMapEntry>? KeyMapEntries
  {
    get
    {
      if (_KeyMapEntries != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>()
            .Select(item => new DocumentModel.Wordprocessing.KeyMapEntryImpl(item)).ToList();
          _KeyMapEntries = new ObservableCollection<DocumentModel.Wordprocessing.KeyMapEntry>(items);
        }
        else
          _KeyMapEntries = new ObservableCollection<DocumentModel.Wordprocessing.KeyMapEntry>();
        _KeyMapEntries.CollectionChanged += _KeyMapEntries_CollectionChanged;
      }
      return _KeyMapEntries;
    }
    set
    {
      if (value != null && value != _KeyMapEntries && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.KeyMapEntryImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.KeyMapEntry> observableCollection)
        _KeyMapEntries = observableCollection;
      else if (value != null)
        _KeyMapEntries = new ObservableCollection<DocumentModel.Wordprocessing.KeyMapEntry>(value);
      else
       _KeyMapEntries = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.KeyMapEntry>? _KeyMapEntries;
  
  private void _KeyMapEntries_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.KeyMapEntryImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.KeyMapEntryImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>()
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
