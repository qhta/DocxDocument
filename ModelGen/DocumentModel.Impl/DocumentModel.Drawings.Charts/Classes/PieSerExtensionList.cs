namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PieSerExtensionList Class.
/// </summary>
public partial class PieSerExtensionListImpl: ModelElementImpl, PieSerExtensionList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PieSerExtensionListImpl(): base() {}
  
  public PieSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.PieSerExtension>? PieSerExtensions
  {
    get
    {
      if (_PieSerExtensions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.PieSerExtensionImpl(item)).ToList();
          _PieSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.PieSerExtension>(items);
        }
        else
          _PieSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.PieSerExtension>();
        _PieSerExtensions.CollectionChanged += _PieSerExtensions_CollectionChanged;
      }
      return _PieSerExtensions;
    }
    set
    {
      if (value != null && value != _PieSerExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.PieSerExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.PieSerExtension> observableCollection)
        _PieSerExtensions = observableCollection;
      else if (value != null)
        _PieSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.PieSerExtension>(value);
      else
       _PieSerExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.PieSerExtension>? _PieSerExtensions;
  
  private void _PieSerExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.PieSerExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.PieSerExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>()
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
