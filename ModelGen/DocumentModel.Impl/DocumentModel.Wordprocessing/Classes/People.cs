namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the People Class.
/// </summary>
public class PeopleImpl: ModelElementImpl, People
{
  public DocumentFormat.OpenXml.Office2013.Word.People? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.People?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PeopleImpl(): base() {}
  
  public PeopleImpl(DocumentFormat.OpenXml.Office2013.Word.People openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.Person>? Persons
  {
    get
    {
      if (_Persons != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Word.Person>()
            .Select(item => new DocumentModel.Wordprocessing.PersonImpl(item)).ToList();
          _Persons = new ObservableCollection<DocumentModel.Wordprocessing.Person>(items);
        }
        else
          _Persons = new ObservableCollection<DocumentModel.Wordprocessing.Person>();
        _Persons.CollectionChanged += _Persons_CollectionChanged;
      }
      return _Persons;
    }
    set
    {
      if (value != null && value != _Persons && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Word.Person>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.PersonImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.Person> observableCollection)
        _Persons = observableCollection;
      else if (value != null)
        _Persons = new ObservableCollection<DocumentModel.Wordprocessing.Person>(value);
      else
       _Persons = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.Person>? _Persons;
  
  private void _Persons_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Word.Person>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.PersonImpl valImpl)
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
        if (val is DocumentModel.Wordprocessing.PersonImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Word.Person>()
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
