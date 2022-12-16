namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Rule List.
/// </summary>
public class RuleListImpl: ModelElementImpl, RuleList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.RuleList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.RuleList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RuleListImpl(): base() {}
  
  public RuleListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.Rule>? Rules
  {
    get
    {
      if (_Rules != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>()
            .Select(item => new DocumentModel.Drawings.Diagrams.RuleImpl(item)).ToList();
          _Rules = new ObservableCollection<DocumentModel.Drawings.Diagrams.Rule>(items);
        }
        else
          _Rules = new ObservableCollection<DocumentModel.Drawings.Diagrams.Rule>();
        _Rules.CollectionChanged += _Rules_CollectionChanged;
      }
      return _Rules;
    }
    set
    {
      if (value != null && value != _Rules && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Diagrams.RuleImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.Rule> observableCollection)
        _Rules = observableCollection;
      else if (value != null)
        _Rules = new ObservableCollection<DocumentModel.Drawings.Diagrams.Rule>(value);
      else
       _Rules = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.Rule>? _Rules;
  
  private void _Rules_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Diagrams.RuleImpl valImpl)
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
        if (val is DocumentModel.Drawings.Diagrams.RuleImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>()
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
