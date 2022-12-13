namespace DocumentModel.Drawings16.Charts;

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
  public DocumentModel.Drawings16.Charts.DataLabelPos? Pos
  {
    get => (DocumentModel.Drawings16.Charts.DataLabelPos?)OpenXmlElement?.Pos?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pos = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos?)value;
    }
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public DocumentModel.Drawings16.Charts.NumberFormat? NumberFormat
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings16.Charts.TxPrTextBody? TxPrTextBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public DocumentModel.Drawings16.Charts.DataLabelVisibilities? DataLabelVisibilities
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
  
  public Collection<DocumentModel.Drawings16.Charts.DataLabel>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel>()
            .Select(item => new DocumentModel.Drawings16.Charts.DataLabelImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.DataLabel>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.DataLabel>();
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
        if (val is DocumentModel.Drawings16.Charts.DataLabelImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings16.Charts.DataLabel> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.DataLabel>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings16.Charts.DataLabel>? _Items;
  
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
          if (val is DocumentModel.Drawings16.Charts.DataLabelImpl valImpl)
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
        if (val is DocumentModel.Drawings16.Charts.DataLabelImpl valImpl)
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
  
  
  public Collection<DocumentModel.Drawings16.Charts.DataLabelHidden>? DataLabelHiddens
  {
    get
    {
      if (_DataLabelHiddens != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden>()
            .Select(item => new DocumentModel.Drawings16.Charts.DataLabelHiddenImpl(item)).ToList();
          _DataLabelHiddens = new ObservableCollection<DocumentModel.Drawings16.Charts.DataLabelHidden>(items);
        }
        else
          _DataLabelHiddens = new ObservableCollection<DocumentModel.Drawings16.Charts.DataLabelHidden>();
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
        if (val is DocumentModel.Drawings16.Charts.DataLabelHiddenImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings16.Charts.DataLabelHidden> observableCollection)
        _DataLabelHiddens = observableCollection;
      else if (value != null)
        _DataLabelHiddens = new ObservableCollection<DocumentModel.Drawings16.Charts.DataLabelHidden>(value);
      else
       _DataLabelHiddens = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings16.Charts.DataLabelHidden>? _DataLabelHiddens;
  
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
          if (val is DocumentModel.Drawings16.Charts.DataLabelHiddenImpl valImpl)
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
        if (val is DocumentModel.Drawings16.Charts.DataLabelHiddenImpl valImpl)
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
  
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
