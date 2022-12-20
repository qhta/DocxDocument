namespace DocumentModel.UI;

/// <summary>
/// Defines the RepurposedCommands Class.
/// </summary>
public partial class RepurposedCommandsImpl: ModelElementImpl, RepurposedCommands
{
  public DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RepurposedCommandsImpl(): base() {}
  
  public RepurposedCommandsImpl(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.UI.RepurposedCommand>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>()
            .Select(item => new DocumentModel.UI.RepurposedCommandImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.UI.RepurposedCommand>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.UI.RepurposedCommand>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>();
        foreach (var val in value)
        {
          if (val is DocumentModel.UI.RepurposedCommandImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.UI.RepurposedCommand> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.UI.RepurposedCommand>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.UI.RepurposedCommand>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.UI.RepurposedCommandImpl valImpl)
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
              if (val is DocumentModel.UI.RepurposedCommandImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>()
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
