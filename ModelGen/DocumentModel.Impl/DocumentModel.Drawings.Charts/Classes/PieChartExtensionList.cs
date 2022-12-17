namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PieChartExtensionList Class.
/// </summary>
public class PieChartExtensionListImpl: ModelElementImpl, PieChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PieChartExtensionListImpl(): base() {}
  
  public PieChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.PieChartExtension>? PieChartExtensions
  {
    get
    {
      if (_PieChartExtensions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension>()
            .Select(item => new DocumentModel.Drawings.Charts.PieChartExtensionImpl(item)).ToList();
          _PieChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.PieChartExtension>(items);
        }
        else
          _PieChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.PieChartExtension>();
        _PieChartExtensions.CollectionChanged += _PieChartExtensions_CollectionChanged;
      }
      return _PieChartExtensions;
    }
    set
    {
      if (value != null && value != _PieChartExtensions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.PieChartExtensionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.PieChartExtension> observableCollection)
        _PieChartExtensions = observableCollection;
      else if (value != null)
        _PieChartExtensions = new ObservableCollection<DocumentModel.Drawings.Charts.PieChartExtension>(value);
      else
       _PieChartExtensions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.PieChartExtension>? _PieChartExtensions;
  
  private void _PieChartExtensions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.PieChartExtensionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.PieChartExtensionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension>()
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
