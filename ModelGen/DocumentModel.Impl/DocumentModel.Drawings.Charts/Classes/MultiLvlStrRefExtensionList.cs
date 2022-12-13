namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the MultiLvlStrRefExtensionList Class.
/// </summary>
public class MultiLvlStrRefExtensionListImpl: ModelElementImpl, MultiLvlStrRefExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MultiLvlStrRefExtensionListImpl(): base() {}
  
  public MultiLvlStrRefExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.MultiLvlStrRefExtension>? MultiLvlStrRefExtensions
  {
    get
    {
      if (_MultiLvlStrRefExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionImpl(item)).ToList();
          _MultiLvlStrRefExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.MultiLvlStrRefExtension>(items);
        }
        else
          _MultiLvlStrRefExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.MultiLvlStrRefExtension>();
        _MultiLvlStrRefExtensions.CollectionChanged += _MultiLvlStrRefExtensions_CollectionChanged;
      }
      return _MultiLvlStrRefExtensions;
    }
    set
    {
      if (value != null && value != _MultiLvlStrRefExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.MultiLvlStrRefExtension> observableCollection)
        _MultiLvlStrRefExtensions = observableCollection;
      else if (value != null)
        _MultiLvlStrRefExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.MultiLvlStrRefExtension>(value);
      else
       _MultiLvlStrRefExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.MultiLvlStrRefExtension>? _MultiLvlStrRefExtensions;
  
  private void _MultiLvlStrRefExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>()
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
