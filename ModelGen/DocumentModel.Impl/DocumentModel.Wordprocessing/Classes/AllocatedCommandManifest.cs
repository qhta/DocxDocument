namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public class AllocatedCommandManifestImpl: ModelElementImpl, AllocatedCommandManifest
{
  public DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AllocatedCommandManifestImpl(): base() {}
  
  public AllocatedCommandManifestImpl(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.AcceleratorKeymapType>? AllocatedCommandManifestEntries
  {
    get
    {
      if (_AllocatedCommandManifestEntries != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry>()
            .Select(item => new DocumentModel.Wordprocessing.AcceleratorKeymapTypeImpl(item)).ToList();
          _AllocatedCommandManifestEntries = new ObservableCollection<DocumentModel.Wordprocessing.AcceleratorKeymapType>(items);
        }
        else
          _AllocatedCommandManifestEntries = new ObservableCollection<DocumentModel.Wordprocessing.AcceleratorKeymapType>();
        _AllocatedCommandManifestEntries.CollectionChanged += _AllocatedCommandManifestEntries_CollectionChanged;
      }
      return _AllocatedCommandManifestEntries;
    }
    set
    {
      if (value != null && value != _AllocatedCommandManifestEntries && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.AcceleratorKeymapTypeImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.AcceleratorKeymapType> observableCollection)
        _AllocatedCommandManifestEntries = observableCollection;
      else if (value != null)
        _AllocatedCommandManifestEntries = new ObservableCollection<DocumentModel.Wordprocessing.AcceleratorKeymapType>(value);
      else
       _AllocatedCommandManifestEntries = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.AcceleratorKeymapType>? _AllocatedCommandManifestEntries;
  
  private void _AllocatedCommandManifestEntries_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.AcceleratorKeymapTypeImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.AcceleratorKeymapTypeImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry>()
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
