namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Legend data and formatting.
/// </summary>
public partial class LegendImpl: ModelElementImpl, Legend
{
  public DocumentFormat.OpenXml.Drawing.Charts.Legend? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Legend?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LegendImpl(): base() {}
  
  public LegendImpl(DocumentFormat.OpenXml.Drawing.Charts.Legend openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Legend Position.
  /// </summary>
  public DocumentModel.Drawings.Charts.LegendPositionKind? LegendPosition
  {
    get => (DocumentModel.Drawings.Charts.LegendPositionKind?)OpenXmlElement?.LegendPosition?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LegendPosition != null)
        {
          if (value is not null)
            OpenXmlElement.LegendPosition.Val = (DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues?)value;
          else
            OpenXmlElement.LegendPosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LegendPosition = new DocumentFormat.OpenXml.Drawing.Charts.LegendPosition{ Val = (DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues?)value };
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.Charts.LegendEntry>? LegendEntries
  {
    get
    {
      if (_LegendEntries != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>()
            .Select(item => new DocumentModel.Drawings.Charts.LegendEntryImpl(item)).ToList();
          _LegendEntries = new ObservableCollection<DocumentModel.Drawings.Charts.LegendEntry>(items);
        }
        else
          _LegendEntries = new ObservableCollection<DocumentModel.Drawings.Charts.LegendEntry>();
        _LegendEntries.CollectionChanged += _LegendEntries_CollectionChanged;
      }
      return _LegendEntries;
    }
    set
    {
      if (value != null && value != _LegendEntries && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.LegendEntryImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.LegendEntry> observableCollection)
        _LegendEntries = observableCollection;
      else if (value != null)
        _LegendEntries = new ObservableCollection<DocumentModel.Drawings.Charts.LegendEntry>(value);
      else
       _LegendEntries = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.LegendEntry>? _LegendEntries;
  
  private void _LegendEntries_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.LegendEntryImpl valImpl)
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
              if (val is DocumentModel.Drawings.Charts.LegendEntryImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>()
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
  
  
  public DocumentModel.Drawings.Charts.Layout? Layout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.LayoutImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.LayoutImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? Overlay
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Overlay>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Overlay>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Overlay{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ChartShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ChartShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.TextPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.TextPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
