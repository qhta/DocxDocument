namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Subtotals Class.
/// </summary>
public partial class SubtotalsImpl: ModelElementImpl, Subtotals
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SubtotalsImpl(): base() {}
  
  public SubtotalsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<System.UInt32>? UnsignedIntegerTypes
  {
    get
    {
      if (_UnsignedIntegerTypes != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType>()
            .Select(item => item.Val?.Value ?? default).ToList();
          _UnsignedIntegerTypes = new ObservableCollection<System.UInt32>(items);
        }
        else
          _UnsignedIntegerTypes = new ObservableCollection<System.UInt32>();
        _UnsignedIntegerTypes.CollectionChanged += _UnsignedIntegerTypes_CollectionChanged;
      }
      return _UnsignedIntegerTypes;
    }
    set
    {
      if (value != null && value != _UnsignedIntegerTypes && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType>();
        foreach (var val in value)
        {
          var item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType{ Val = val };
          OpenXmlElement.AddChild(item);
        }
      }
      if (value is ObservableCollection<System.UInt32> observableCollection)
        _UnsignedIntegerTypes = observableCollection;
      else if (value != null)
        _UnsignedIntegerTypes = new ObservableCollection<System.UInt32>(value);
      else
       _UnsignedIntegerTypes = null;
    }
  }
  private ObservableCollection<System.UInt32>? _UnsignedIntegerTypes;
  
  private void _UnsignedIntegerTypes_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            var newItem = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType { Val = (UInt32)val };
            OpenXmlElement.AddChild(newItem);
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType>()
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
