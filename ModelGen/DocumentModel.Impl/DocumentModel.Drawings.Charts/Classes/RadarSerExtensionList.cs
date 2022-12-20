namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the RadarSerExtensionList Class.
/// </summary>
public partial class RadarSerExtensionListImpl: ModelElementImpl, RadarSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RadarSerExtensionListImpl(): base() {}
  
  public RadarSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.RadarSerExtension>? RadarSerExtensions
  {
    get
    {
      if (_RadarSerExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.RadarSerExtensionImpl(item)).ToList();
          _RadarSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.RadarSerExtension>(items);
        }
        else
          _RadarSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.RadarSerExtension>();
        _RadarSerExtensions.CollectionChanged += _RadarSerExtensions_CollectionChanged;
      }
      return _RadarSerExtensions;
    }
    set
    {
      if (value != null && value != _RadarSerExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.RadarSerExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.RadarSerExtension> observableCollection)
        _RadarSerExtensions = observableCollection;
      else if (value != null)
        _RadarSerExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.RadarSerExtension>(value);
      else
       _RadarSerExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.RadarSerExtension>? _RadarSerExtensions;
  
  private void _RadarSerExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.RadarSerExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.RadarSerExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension>()
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
