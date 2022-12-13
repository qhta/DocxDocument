namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Custom Split.
/// </summary>
public class CustomSplitImpl: ModelElementImpl, CustomSplit
{
  public DocumentFormat.OpenXml.Drawing.Charts.CustomSplit? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.CustomSplit?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomSplitImpl(): base() {}
  
  public CustomSplitImpl(DocumentFormat.OpenXml.Drawing.Charts.CustomSplit openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<System.UInt32>? SecondPiePoints
  {
    get
    {
      if (_SecondPiePoints != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SecondPiePoint>()
            .Select(item => item.Val?.Value ?? default).ToList();
          _SecondPiePoints = new ObservableCollection<System.UInt32>(items);
        }
        else
          _SecondPiePoints = new ObservableCollection<System.UInt32>();
        _SecondPiePoints.CollectionChanged += _SecondPiePoints_CollectionChanged;
      }
      return _SecondPiePoints;
    }
    set
    {
      if (value != null && value != _SecondPiePoints && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SecondPiePoint>();
        foreach (var val in value)
        {
          var item = new DocumentFormat.OpenXml.Drawing.Charts.SecondPiePoint{ Val = val };
          OpenXmlElement.AddChild(item);
        }
      }
      if (value is ObservableCollection<System.UInt32> observableCollection)
        _SecondPiePoints = observableCollection;
      else if (value != null)
        _SecondPiePoints = new ObservableCollection<System.UInt32>(value);
      else
       _SecondPiePoints = null;
    }
  }
  private ObservableCollection<System.UInt32>? _SecondPiePoints;
  
  private void _SecondPiePoints_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SecondPiePoint>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            var newItem = new DocumentFormat.OpenXml.Drawing.Charts.SecondPiePoint { Val = (UInt32)val };
            OpenXmlElement.AddChild(newItem);
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SecondPiePoint>()
                          .FirstOrDefault(anItem => anItem.Val?.Value == (UInt32)val);
            if (oldItem != null)
              oldItem.Remove();
          }
          break;
        default:
          break;
      }
    }
  }
  
  
}
