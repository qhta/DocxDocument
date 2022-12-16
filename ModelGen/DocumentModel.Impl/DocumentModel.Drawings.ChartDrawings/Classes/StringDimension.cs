namespace DocumentModel.Drawings.ChartDrawings;

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
  public DocumentModel.Drawings.ChartDrawings.StringDimensionType? Type
  {
    get => (DocumentModel.Drawings.ChartDrawings.StringDimensionType?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType?)value;
    }
  }
  
  public DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? Formula
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElementImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElementImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? NfFormula
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElementImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElementImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.StringLevel>? StringLevels
  {
    get
    {
      if (_StringLevels != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.StringLevelImpl(item)).ToList();
          _StringLevels = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.StringLevel>(items);
        }
        else
          _StringLevels = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.StringLevel>();
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
        if (val is DocumentModel.Drawings.ChartDrawings.StringLevelImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.StringLevel> observableCollection)
        _StringLevels = observableCollection;
      else if (value != null)
        _StringLevels = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.StringLevel>(value);
      else
       _StringLevels = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.StringLevel>? _StringLevels;
  
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
          if (val is DocumentModel.Drawings.ChartDrawings.StringLevelImpl valImpl)
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
        if (val is DocumentModel.Drawings.ChartDrawings.StringLevelImpl valImpl)
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
  
  
  public DocumentModel.Drawings.ChartDrawings.StringLevel? StringLevel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.StringLevelImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.StringLevelImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
