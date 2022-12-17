namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommands Class.
/// </summary>
public class AllocatedCommandsImpl: ModelElementImpl, AllocatedCommands
{
  public DocumentFormat.OpenXml.Office.Word.AllocatedCommands? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.AllocatedCommands?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AllocatedCommandsImpl(): base() {}
  
  public AllocatedCommandsImpl(DocumentFormat.OpenXml.Office.Word.AllocatedCommands openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.AllocatedCommand>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>()
            .Select(item => new DocumentModel.Wordprocessing.AllocatedCommandImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommand>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommand>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.AllocatedCommandImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommand> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommand>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommand>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.AllocatedCommandImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.AllocatedCommandImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>()
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
