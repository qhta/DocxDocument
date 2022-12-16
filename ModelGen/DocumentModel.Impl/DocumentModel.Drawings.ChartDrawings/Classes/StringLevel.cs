namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringLevel Class.
/// </summary>
public class StringLevelImpl: ModelElementImpl, StringLevel
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StringLevelImpl(): base() {}
  
  public StringLevelImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? PtCount
  {
    get => (System.UInt32?)OpenXmlElement?.PtCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PtCount = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.ChartStringValue>? ChartStringValues
  {
    get
    {
      if (_ChartStringValues != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.ChartStringValueImpl(item)).ToList();
          _ChartStringValues = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.ChartStringValue>(items);
        }
        else
          _ChartStringValues = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.ChartStringValue>();
        _ChartStringValues.CollectionChanged += _ChartStringValues_CollectionChanged;
      }
      return _ChartStringValues;
    }
    set
    {
      if (value != null && value != _ChartStringValues && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.ChartDrawings.ChartStringValueImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.ChartStringValue> observableCollection)
        _ChartStringValues = observableCollection;
      else if (value != null)
        _ChartStringValues = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.ChartStringValue>(value);
      else
       _ChartStringValues = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.ChartStringValue>? _ChartStringValues;
  
  private void _ChartStringValues_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.ChartDrawings.ChartStringValueImpl valImpl)
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
        if (val is DocumentModel.Drawings.ChartDrawings.ChartStringValueImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue>()
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
