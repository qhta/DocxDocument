namespace DocumentModel.Drawings.Charts;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public partial class Pie3DChartImpl: ModelElementImpl, Pie3DChart
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public Pie3DChartImpl(): base() {}
  
  public Pie3DChartImpl(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.VaryColors();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.Charts.PieChartSeries>? PieChartSerieses
  {
    get
    {
      if (_PieChartSerieses == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>()
            .Select(item => new DocumentModel.Drawings.Charts.PieChartSeriesImpl(item)).ToList();
          _PieChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.PieChartSeries>(items);
        }
        else
          _PieChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.PieChartSeries>();
        _PieChartSerieses.CollectionChanged += _PieChartSerieses_CollectionChanged;
      }
      return _PieChartSerieses;
    }
    set
    {
      if (value != null && value != _PieChartSerieses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.PieChartSeriesImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.PieChartSeries> observableCollection)
        _PieChartSerieses = observableCollection;
      else if (value != null)
        _PieChartSerieses = new ObservableCollection<DocumentModel.Drawings.Charts.PieChartSeries>(value);
      else
       _PieChartSerieses = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.PieChartSeries>? _PieChartSerieses;
  
  private void _PieChartSerieses_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.PieChartSeriesImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Drawings.Charts.PieChartSeriesImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>()
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
  
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.DataLabelsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.DataLabelsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.Pie3DChartExtensionList? Pie3DChartExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.Pie3DChartExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.Pie3DChartExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
