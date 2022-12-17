namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Band Formats.
/// </summary>
public class BandFormatsImpl: ModelElementImpl, BandFormats
{
  public DocumentFormat.OpenXml.Drawing.Charts.BandFormats? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BandFormats?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BandFormatsImpl(): base() {}
  
  public BandFormatsImpl(DocumentFormat.OpenXml.Drawing.Charts.BandFormats openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.BandFormat>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>()
            .Select(item => new DocumentModel.Drawings.Charts.BandFormatImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings.Charts.BandFormat>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings.Charts.BandFormat>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.BandFormatImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.BandFormat> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings.Charts.BandFormat>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.BandFormat>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.BandFormatImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.BandFormatImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>()
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
