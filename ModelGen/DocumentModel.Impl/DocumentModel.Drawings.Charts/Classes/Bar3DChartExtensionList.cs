namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Bar3DChartExtensionList Class.
/// </summary>
public partial class Bar3DChartExtensionListImpl: ModelElementImpl, Bar3DChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Bar3DChartExtensionListImpl(): base() {}
  
  public Bar3DChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.Bar3DChartExtension>? Bar3DChartExtensions
  {
    get
    {
      if (_Bar3DChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.Bar3DChartExtensionImpl(item)).ToList();
          _Bar3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Bar3DChartExtension>(items);
        }
        else
          _Bar3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Bar3DChartExtension>();
        _Bar3DChartExtensions.CollectionChanged += _Bar3DChartExtensions_CollectionChanged;
      }
      return _Bar3DChartExtensions;
    }
    set
    {
      if (value != null && value != _Bar3DChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.Bar3DChartExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.Bar3DChartExtension> observableCollection)
        _Bar3DChartExtensions = observableCollection;
      else if (value != null)
        _Bar3DChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.Bar3DChartExtension>(value);
      else
       _Bar3DChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.Bar3DChartExtension>? _Bar3DChartExtensions;
  
  private void _Bar3DChartExtensions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.Bar3DChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.Bar3DChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension>()
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
