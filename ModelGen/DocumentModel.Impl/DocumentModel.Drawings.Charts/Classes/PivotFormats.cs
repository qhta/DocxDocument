namespace DocumentModel.Drawings.Charts;

/// <summary>
/// pivot chart format persistence data.
/// </summary>
public partial class PivotFormatsImpl: ModelElementImpl, PivotFormats
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.PivotFormats? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PivotFormats?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PivotFormatsImpl(): base() {}
  
  public PivotFormatsImpl(DocumentFormat.OpenXml.Drawing.Charts.PivotFormats openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.PivotFormat>? Items
  {
    get
    {
      if (_Items == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PivotFormat>()
            .Select(item => new DocumentModel.Drawings.Charts.PivotFormatImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings.Charts.PivotFormat>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings.Charts.PivotFormat>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PivotFormat>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.PivotFormatImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.PivotFormat> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings.Charts.PivotFormat>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.PivotFormat>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PivotFormat>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.PivotFormatImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.PivotFormatImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PivotFormat>()
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
