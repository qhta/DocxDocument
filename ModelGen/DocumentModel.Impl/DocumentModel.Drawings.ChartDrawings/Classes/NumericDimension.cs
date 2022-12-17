namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public class NumericDimensionImpl: ModelElementImpl, NumericDimension
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumericDimensionImpl(): base() {}
  
  public NumericDimensionImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NumericDimensionType? Type
  {
    get => (DocumentModel.Drawings.ChartDrawings.NumericDimensionType?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType?)value;
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
  
  public Collection<DocumentModel.Drawings.ChartDrawings.NumericLevel>? NumericLevels
  {
    get
    {
      if (_NumericLevels != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.NumericLevelImpl(item)).ToList();
          _NumericLevels = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.NumericLevel>(items);
        }
        else
          _NumericLevels = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.NumericLevel>();
        _NumericLevels.CollectionChanged += _NumericLevels_CollectionChanged;
      }
      return _NumericLevels;
    }
    set
    {
      if (value != null && value != _NumericLevels && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ChartDrawings.NumericLevelImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.NumericLevel> observableCollection)
        _NumericLevels = observableCollection;
      else if (value != null)
        _NumericLevels = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.NumericLevel>(value);
      else
       _NumericLevels = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.NumericLevel>? _NumericLevels;
  
  private void _NumericLevels_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ChartDrawings.NumericLevelImpl valImpl)
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
              if (val is DocumentModel.Drawings.ChartDrawings.NumericLevelImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>()
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
  
  
  public DocumentModel.Drawings.ChartDrawings.NumericLevel? NumericLevel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.NumericLevelImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.NumericLevelImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
