namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentComboBox Class.
/// </summary>
public class SdtContentComboBoxImpl: ModelElementImpl, SdtContentComboBox
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtContentComboBoxImpl(): base() {}
  
  public SdtContentComboBoxImpl(DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Combo Box Last Saved Value
  /// </summary>
  public String? LastValue
  {
    get => (System.String?)OpenXmlElement?.LastValue?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastValue = (System.String?)value;
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.ListItem>? ListItems
  {
    get
    {
      if (_ListItems != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ListItem>()
            .Select(item => new DocumentModel.Wordprocessing.ListItemImpl(item)).ToList();
          _ListItems = new ObservableCollection<DocumentModel.Wordprocessing.ListItem>(items);
        }
        else
          _ListItems = new ObservableCollection<DocumentModel.Wordprocessing.ListItem>();
        _ListItems.CollectionChanged += _ListItems_CollectionChanged;
      }
      return _ListItems;
    }
    set
    {
      if (value != null && value != _ListItems && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ListItem>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.ListItemImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.ListItem> observableCollection)
        _ListItems = observableCollection;
      else if (value != null)
        _ListItems = new ObservableCollection<DocumentModel.Wordprocessing.ListItem>(value);
      else
       _ListItems = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.ListItem>? _ListItems;
  
  private void _ListItems_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ListItem>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.ListItemImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.ListItemImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ListItem>()
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
