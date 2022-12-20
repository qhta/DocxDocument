namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the NumRefExtensionList Class.
/// </summary>
public partial class NumRefExtensionListImpl: ModelElementImpl, NumRefExtensionList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NumRefExtensionListImpl(): base() {}
  
  public NumRefExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.NumRefExtension>? NumRefExtensions
  {
    get
    {
      if (_NumRefExtensions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.NumRefExtensionImpl(item)).ToList();
          _NumRefExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.NumRefExtension>(items);
        }
        else
          _NumRefExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.NumRefExtension>();
        _NumRefExtensions.CollectionChanged += _NumRefExtensions_CollectionChanged;
      }
      return _NumRefExtensions;
    }
    set
    {
      if (value != null && value != _NumRefExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.NumRefExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.NumRefExtension> observableCollection)
        _NumRefExtensions = observableCollection;
      else if (value != null)
        _NumRefExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.NumRefExtension>(value);
      else
       _NumRefExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.NumRefExtension>? _NumRefExtensions;
  
  private void _NumRefExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.NumRefExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.NumRefExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>()
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
