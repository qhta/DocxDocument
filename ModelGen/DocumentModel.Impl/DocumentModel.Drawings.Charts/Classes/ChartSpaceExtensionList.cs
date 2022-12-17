namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ChartSpaceExtensionList Class.
/// </summary>
public class ChartSpaceExtensionListImpl: ModelElementImpl, ChartSpaceExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartSpaceExtensionListImpl(): base() {}
  
  public ChartSpaceExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.ChartSpaceExtension>? ChartSpaceExtensions
  {
    get
    {
      if (_ChartSpaceExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.ChartSpaceExtensionImpl(item)).ToList();
          _ChartSpaceExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ChartSpaceExtension>(items);
        }
        else
          _ChartSpaceExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ChartSpaceExtension>();
        _ChartSpaceExtensions.CollectionChanged += _ChartSpaceExtensions_CollectionChanged;
      }
      return _ChartSpaceExtensions;
    }
    set
    {
      if (value != null && value != _ChartSpaceExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.ChartSpaceExtensionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.ChartSpaceExtension> observableCollection)
        _ChartSpaceExtensions = observableCollection;
      else if (value != null)
        _ChartSpaceExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.ChartSpaceExtension>(value);
      else
       _ChartSpaceExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.ChartSpaceExtension>? _ChartSpaceExtensions;
  
  private void _ChartSpaceExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.ChartSpaceExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.ChartSpaceExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>()
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
