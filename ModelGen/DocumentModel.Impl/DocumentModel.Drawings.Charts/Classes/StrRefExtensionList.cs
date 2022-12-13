namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StrRefExtensionList Class.
/// </summary>
public class StrRefExtensionListImpl: ModelElementImpl, StrRefExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StrRefExtensionListImpl(): base() {}
  
  public StrRefExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.StrRefExtension>? StrRefExtensions
  {
    get
    {
      if (_StrRefExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.StrRefExtensionImpl(item)).ToList();
          _StrRefExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.StrRefExtension>(items);
        }
        else
          _StrRefExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.StrRefExtension>();
        _StrRefExtensions.CollectionChanged += _StrRefExtensions_CollectionChanged;
      }
      return _StrRefExtensions;
    }
    set
    {
      if (value != null && value != _StrRefExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.StrRefExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.StrRefExtension> observableCollection)
        _StrRefExtensions = observableCollection;
      else if (value != null)
        _StrRefExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.StrRefExtension>(value);
      else
       _StrRefExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.StrRefExtension>? _StrRefExtensions;
  
  private void _StrRefExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.StrRefExtensionImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.StrRefExtensionImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension>()
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
