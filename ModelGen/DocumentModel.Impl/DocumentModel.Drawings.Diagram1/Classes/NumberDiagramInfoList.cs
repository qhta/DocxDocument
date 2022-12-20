namespace DocumentModel.Drawings.Diagram1;

/// <summary>
/// Defines the NumberDiagramInfoList Class.
/// </summary>
public partial class NumberDiagramInfoListImpl: ModelElementImpl, NumberDiagramInfoList
{
  public DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberDiagramInfoListImpl(): base() {}
  
  public NumberDiagramInfoListImpl(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Diagram1.NumberDiagramInfo>? NumberDiagramInfos
  {
    get
    {
      if (_NumberDiagramInfos != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>()
            .Select(item => new DocumentModel.Drawings.Diagram1.NumberDiagramInfoImpl(item)).ToList();
          _NumberDiagramInfos = new ObservableCollection<DocumentModel.Drawings.Diagram1.NumberDiagramInfo>(items);
        }
        else
          _NumberDiagramInfos = new ObservableCollection<DocumentModel.Drawings.Diagram1.NumberDiagramInfo>();
        _NumberDiagramInfos.CollectionChanged += _NumberDiagramInfos_CollectionChanged;
      }
      return _NumberDiagramInfos;
    }
    set
    {
      if (value != null && value != _NumberDiagramInfos && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagram1.NumberDiagramInfoImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagram1.NumberDiagramInfo> observableCollection)
        _NumberDiagramInfos = observableCollection;
      else if (value != null)
        _NumberDiagramInfos = new ObservableCollection<DocumentModel.Drawings.Diagram1.NumberDiagramInfo>(value);
      else
       _NumberDiagramInfos = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagram1.NumberDiagramInfo>? _NumberDiagramInfos;
  
  private void _NumberDiagramInfos_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagram1.NumberDiagramInfoImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagram1.NumberDiagramInfoImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>()
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
