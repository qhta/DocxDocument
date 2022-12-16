namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabels Class.
/// </summary>
public class DataLabelsImpl: ModelElementImpl, DataLabels
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataLabelsImpl(): base() {}
  
  public DataLabelsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.DataLabelPos? Pos
  {
    get => (DocumentModel.Drawings.ChartDrawings.DataLabelPos?)OpenXmlElement?.Pos?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pos = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos?)value;
    }
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NumberFormat? NumberFormat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.NumberFormatImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.NumberFormatImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.TxPrTextBody? TxPrTextBody
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.TxPrTextBodyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.TxPrTextBodyImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? DataLabelVisibilities
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.DataLabelVisibilitiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.DataLabelVisibilitiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public String? SeparatorXsdstring
  {
    get => (System.String?)OpenXmlElement?.SeparatorXsdstring?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SeparatorXsdstring != null)
        {
          if (value is not null)
            OpenXmlElement.SeparatorXsdstring.Text = value;
          else
            OpenXmlElement.SeparatorXsdstring = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SeparatorXsdstring = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring{ Text = value };
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.DataLabel>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.DataLabelImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataLabel>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataLabel>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.ChartDrawings.DataLabelImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataLabel> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataLabel>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataLabel>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.ChartDrawings.DataLabelImpl valImpl)
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
        if (val is DocumentModel.Drawings.ChartDrawings.DataLabelImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel>()
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
  
  
  public Collection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>? DataLabelHiddens
  {
    get
    {
      if (_DataLabelHiddens != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.DataLabelHiddenImpl(item)).ToList();
          _DataLabelHiddens = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>(items);
        }
        else
          _DataLabelHiddens = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>();
        _DataLabelHiddens.CollectionChanged += _DataLabelHiddens_CollectionChanged;
      }
      return _DataLabelHiddens;
    }
    set
    {
      if (value != null && value != _DataLabelHiddens && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.ChartDrawings.DataLabelHiddenImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden> observableCollection)
        _DataLabelHiddens = observableCollection;
      else if (value != null)
        _DataLabelHiddens = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>(value);
      else
       _DataLabelHiddens = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>? _DataLabelHiddens;
  
  private void _DataLabelHiddens_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.ChartDrawings.DataLabelHiddenImpl valImpl)
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
        if (val is DocumentModel.Drawings.ChartDrawings.DataLabelHiddenImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden>()
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
  
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
