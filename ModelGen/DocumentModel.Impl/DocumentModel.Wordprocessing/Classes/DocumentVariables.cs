namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Variables.
/// </summary>
public partial class DocumentVariablesImpl: ModelElementImpl, DocumentVariables
{
  public DocumentFormat.OpenXml.Wordprocessing.DocumentVariables? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocumentVariables?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocumentVariablesImpl(): base() {}
  
  public DocumentVariablesImpl(DocumentFormat.OpenXml.Wordprocessing.DocumentVariables openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.DocumentVariable>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.DocumentVariable>()
            .Select(item => new DocumentModel.Wordprocessing.DocumentVariableImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.DocumentVariable>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.DocumentVariable>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.DocumentVariable>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.DocumentVariableImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.DocumentVariable> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Wordprocessing.DocumentVariable>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.DocumentVariable>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.DocumentVariable>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.DocumentVariableImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.DocumentVariableImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.DocumentVariable>()
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
