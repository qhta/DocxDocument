namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
public class NumberingCacheImpl: DocumentModel.Drawings.Charts.NumberDataTypeImpl, NumberingCache
{
  public new DocumentFormat.OpenXml.Drawing.Charts.NumberingCache? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumberingCache?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberingCacheImpl(): base() {}
  
  public NumberingCacheImpl(DocumentFormat.OpenXml.Drawing.Charts.NumberingCache openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? FormatCode
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.FormatCode{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public new UInt32? PointCount
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
        return (System.UInt32?)openXmlElement?.Val?.Value;
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
  
  public Collection<DocumentModel.Drawings.Charts.NumericPoint>? NumericPoints
  {
    get
    {
      if (_NumericPoints != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>()
            .Select(item => new DocumentModel.Drawings.Charts.NumericPointImpl(item)).ToList();
          _NumericPoints = new ObservableCollection<DocumentModel.Drawings.Charts.NumericPoint>(items);
        }
        else
          _NumericPoints = new ObservableCollection<DocumentModel.Drawings.Charts.NumericPoint>();
        _NumericPoints.CollectionChanged += _NumericPoints_CollectionChanged;
      }
      return _NumericPoints;
    }
    set
    {
      if (value != null && value != _NumericPoints && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.Charts.NumericPointImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.NumericPoint> observableCollection)
        _NumericPoints = observableCollection;
      else if (value != null)
        _NumericPoints = new ObservableCollection<DocumentModel.Drawings.Charts.NumericPoint>(value);
      else
       _NumericPoints = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.NumericPoint>? _NumericPoints;
  
  private void _NumericPoints_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.Charts.NumericPointImpl valImpl)
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
        if (val is DocumentModel.Drawings.Charts.NumericPointImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>()
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
  
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
