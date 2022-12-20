namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtensionList Class.
/// </summary>
public partial class BubbleChartExtensionListImpl: ModelElementImpl, BubbleChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BubbleChartExtensionListImpl(): base() {}
  
  public BubbleChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.BubbleChartExtension>? BubbleChartExtensions
  {
    get
    {
      if (_BubbleChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.BubbleChartExtensionImpl(item)).ToList();
          _BubbleChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BubbleChartExtension>(items);
        }
        else
          _BubbleChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BubbleChartExtension>();
        _BubbleChartExtensions.CollectionChanged += _BubbleChartExtensions_CollectionChanged;
      }
      return _BubbleChartExtensions;
    }
    set
    {
      if (value != null && value != _BubbleChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.BubbleChartExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.BubbleChartExtension> observableCollection)
        _BubbleChartExtensions = observableCollection;
      else if (value != null)
        _BubbleChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.BubbleChartExtension>(value);
      else
       _BubbleChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.BubbleChartExtension>? _BubbleChartExtensions;
  
  private void _BubbleChartExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.BubbleChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.BubbleChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>()
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
