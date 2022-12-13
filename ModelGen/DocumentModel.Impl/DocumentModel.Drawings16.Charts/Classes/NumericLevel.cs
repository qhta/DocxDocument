namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the NumericLevel Class.
/// </summary>
public class NumericLevelImpl: ModelElementImpl, NumericLevel
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumericLevelImpl(): base() {}
  
  public NumericLevelImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel openXmlElement): base(openXmlElement)
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
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public String? FormatCode
  {
    get => (System.String?)OpenXmlElement?.FormatCode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FormatCode = (System.String?)value;
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
  
  public Collection<DocumentModel.Drawings16.Charts.NumericValue>? NumericValues
  {
    get
    {
      if (_NumericValues != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>()
            .Select(item => new DocumentModel.Drawings16.Charts.NumericValueImpl(item)).ToList();
          _NumericValues = new ObservableCollection<DocumentModel.Drawings16.Charts.NumericValue>(items);
        }
        else
          _NumericValues = new ObservableCollection<DocumentModel.Drawings16.Charts.NumericValue>();
        _NumericValues.CollectionChanged += _NumericValues_CollectionChanged;
      }
      return _NumericValues;
    }
    set
    {
      if (value != null && value != _NumericValues && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings16.Charts.NumericValueImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings16.Charts.NumericValue> observableCollection)
        _NumericValues = observableCollection;
      else if (value != null)
        _NumericValues = new ObservableCollection<DocumentModel.Drawings16.Charts.NumericValue>(value);
      else
       _NumericValues = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings16.Charts.NumericValue>? _NumericValues;
  
  private void _NumericValues_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings16.Charts.NumericValueImpl valImpl)
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
        if (val is DocumentModel.Drawings16.Charts.NumericValueImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>()
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
