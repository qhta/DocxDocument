namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public class StringDimensionImpl: ModelElementImpl, StringDimension
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StringDimensionImpl(): base() {}
  
  public StringDimensionImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.StringDimensionType? Type
  {
    get => (DocumentModel.Drawings16.Charts.StringDimensionType?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType?)value;
    }
  }
  
  public DocumentModel.Drawings16.Charts.OpenXmlFormulaElement? Formula
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.Charts.OpenXmlFormulaElement? NfFormula
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Drawings16.Charts.StringLevel>? StringLevels
  {
    get
    {
      if (_StringLevels != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>()
            .Select(item => new DocumentModel.Drawings16.Charts.StringLevelImpl(item)).ToList();
          _StringLevels = new ObservableCollection<DocumentModel.Drawings16.Charts.StringLevel>(items);
        }
        else
          _StringLevels = new ObservableCollection<DocumentModel.Drawings16.Charts.StringLevel>();
        _StringLevels.CollectionChanged += _StringLevels_CollectionChanged;
      }
      return _StringLevels;
    }
    set
    {
      if (value != null && value != _StringLevels && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings16.Charts.StringLevelImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings16.Charts.StringLevel> observableCollection)
        _StringLevels = observableCollection;
      else if (value != null)
        _StringLevels = new ObservableCollection<DocumentModel.Drawings16.Charts.StringLevel>(value);
      else
       _StringLevels = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings16.Charts.StringLevel>? _StringLevels;
  
  private void _StringLevels_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings16.Charts.StringLevelImpl valImpl)
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
        if (val is DocumentModel.Drawings16.Charts.StringLevelImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>()
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
  
  
  public DocumentModel.Drawings16.Charts.StringLevel? StringLevel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
