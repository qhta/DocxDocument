namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DataLabelsRangeChache Class.
/// </summary>
public class DataLabelsRangeChacheImpl: DocumentModel.Drawings.Charts.StringDataType3Impl, DataLabelsRangeChache
{
  public new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataLabelsRangeChacheImpl(): base() {}
  
  public DataLabelsRangeChacheImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new UInt32? PointCount
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
        return (System.UInt32?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.PointCount{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.Charts.StringPoint>? StringPoints
  {
    get
    {
      if (_StringPoints != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>()
            .Select(item => new DocumentModel.Drawings.Charts.StringPointImpl(item)).ToList();
          _StringPoints = new ObservableCollection<DocumentModel.Drawings.Charts.StringPoint>(items);
        }
        else
          _StringPoints = new ObservableCollection<DocumentModel.Drawings.Charts.StringPoint>();
        _StringPoints.CollectionChanged += _StringPoints_CollectionChanged;
      }
      return _StringPoints;
    }
    set
    {
      if (value != null && value != _StringPoints && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.StringPointImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.StringPoint> observableCollection)
        _StringPoints = observableCollection;
      else if (value != null)
        _StringPoints = new ObservableCollection<DocumentModel.Drawings.Charts.StringPoint>(value);
      else
       _StringPoints = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.StringPoint>? _StringPoints;
  
  private void _StringPoints_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.StringPointImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.StringPointImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>()
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
  
  
  public DocumentModel.Drawings.Charts.StrDataExtensionList? StrDataExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.StrDataExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.StrDataExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
