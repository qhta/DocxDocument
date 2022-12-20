namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public partial class ExtensionListImpl: ModelElementImpl, ExtensionList
{
  public DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtensionListImpl(): base() {}
  
  public ExtensionListImpl(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.Extension>? Extensions
  {
    get
    {
      if (_Extensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension>()
            .Select(item => new DocumentModel.Wordprocessing.ExtensionImpl(item)).ToList();
          _Extensions = new ObservableCollection<DocumentModel.Wordprocessing.Extension>(items);
        }
        else
          _Extensions = new ObservableCollection<DocumentModel.Wordprocessing.Extension>();
        _Extensions.CollectionChanged += _Extensions_CollectionChanged;
      }
      return _Extensions;
    }
    set
    {
      if (value != null && value != _Extensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.ExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.Extension> observableCollection)
        _Extensions = observableCollection;
      else if (value != null)
        _Extensions = new ObservableCollection<DocumentModel.Wordprocessing.Extension>(value);
      else
       _Extensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.Extension>? _Extensions;
  
  private void _Extensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.ExtensionImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.ExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension>()
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
