namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StylisticSets Class.
/// </summary>
public class StylisticSetsImpl: ModelElementImpl, StylisticSets
{
  public DocumentFormat.OpenXml.Office2010.Word.StylisticSets? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.StylisticSets?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StylisticSetsImpl(): base() {}
  
  public StylisticSetsImpl(DocumentFormat.OpenXml.Office2010.Word.StylisticSets openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.StyleSet>? StyleSets
  {
    get
    {
      if (_StyleSets != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Word.StyleSet>()
            .Select(item => new DocumentModel.Wordprocessing.StyleSetImpl(item)).ToList();
          _StyleSets = new ObservableCollection<DocumentModel.Wordprocessing.StyleSet>(items);
        }
        else
          _StyleSets = new ObservableCollection<DocumentModel.Wordprocessing.StyleSet>();
        _StyleSets.CollectionChanged += _StyleSets_CollectionChanged;
      }
      return _StyleSets;
    }
    set
    {
      if (value != null && value != _StyleSets && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Word.StyleSet>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.StyleSetImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.StyleSet> observableCollection)
        _StyleSets = observableCollection;
      else if (value != null)
        _StyleSets = new ObservableCollection<DocumentModel.Wordprocessing.StyleSet>(value);
      else
       _StyleSets = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.StyleSet>? _StyleSets;
  
  private void _StyleSets_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Word.StyleSet>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.StyleSetImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.StyleSetImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Word.StyleSet>()
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
