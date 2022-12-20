namespace DocumentModel;

/// <summary>
/// Defines the Commands Class.
/// </summary>
public partial class CommandsImpl: ModelElementImpl, Commands
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.Commands? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.Commands?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CommandsImpl(): base() {}
  
  public CommandsImpl(DocumentFormat.OpenXml.Office2010.CustomUI.Commands openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Command>? Items
  {
    get
    {
      if (_Items == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Command>()
            .Select(item => new DocumentModel.CommandImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Command>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Command>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Command>();
        foreach (var val in value)
        {
          if (val is DocumentModel.CommandImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Command> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Command>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Command>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Command>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.CommandImpl valImpl)
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
              if (val is DocumentModel.CommandImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Command>()
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
