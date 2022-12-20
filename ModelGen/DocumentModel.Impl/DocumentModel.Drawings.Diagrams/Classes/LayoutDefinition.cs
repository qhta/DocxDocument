namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Layout Definition.
/// </summary>
public partial class LayoutDefinitionImpl: ModelElementImpl, LayoutDefinition
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LayoutDefinitionImpl(): base() {}
  
  public LayoutDefinitionImpl(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// uniqueId
  /// </summary>
  public String? UniqueId
  {
    get => (System.String?)OpenXmlElement?.UniqueId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UniqueId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// minVer
  /// </summary>
  public String? MinVersion
  {
    get => (System.String?)OpenXmlElement?.MinVersion?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinVersion = (System.String?)value;
    }
  }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public String? DefaultStyle
  {
    get => (System.String?)OpenXmlElement?.DefaultStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultStyle = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.DiagramLayoutDefinitionPart? DiagramLayoutDefinitionPart
  {
    get
    {
      if (OpenXmlElement?.DiagramLayoutDefinitionPart != null)
        return new DocumentModel.Packaging.DiagramLayoutDefinitionPartImpl(OpenXmlElement.DiagramLayoutDefinitionPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.DiagramLayoutDefinitionPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.Title>? Titles
  {
    get
    {
      if (_Titles != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Title>()
            .Select(item => new DocumentModel.Drawings.Diagrams.TitleImpl(item)).ToList();
          _Titles = new ObservableCollection<DocumentModel.Drawings.Diagrams.Title>(items);
        }
        else
          _Titles = new ObservableCollection<DocumentModel.Drawings.Diagrams.Title>();
        _Titles.CollectionChanged += _Titles_CollectionChanged;
      }
      return _Titles;
    }
    set
    {
      if (value != null && value != _Titles && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Title>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.TitleImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.Title> observableCollection)
        _Titles = observableCollection;
      else if (value != null)
        _Titles = new ObservableCollection<DocumentModel.Drawings.Diagrams.Title>(value);
      else
       _Titles = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.Title>? _Titles;
  
  private void _Titles_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Title>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.TitleImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.TitleImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Title>()
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
  
  
  public Collection<DocumentModel.Drawings.Diagrams.Description>? Descriptions
  {
    get
    {
      if (_Descriptions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Description>()
            .Select(item => new DocumentModel.Drawings.Diagrams.DescriptionImpl(item)).ToList();
          _Descriptions = new ObservableCollection<DocumentModel.Drawings.Diagrams.Description>(items);
        }
        else
          _Descriptions = new ObservableCollection<DocumentModel.Drawings.Diagrams.Description>();
        _Descriptions.CollectionChanged += _Descriptions_CollectionChanged;
      }
      return _Descriptions;
    }
    set
    {
      if (value != null && value != _Descriptions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Description>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.DescriptionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.Description> observableCollection)
        _Descriptions = observableCollection;
      else if (value != null)
        _Descriptions = new ObservableCollection<DocumentModel.Drawings.Diagrams.Description>(value);
      else
       _Descriptions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.Description>? _Descriptions;
  
  private void _Descriptions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Description>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.DescriptionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.DescriptionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Description>()
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
  
  
  public DocumentModel.Drawings.Diagrams.CategoryList? CategoryList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.CategoryListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.CategoryListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.SampleData? SampleData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.SampleData>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.SampleDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.SampleData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.SampleDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.StyleData? StyleData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleData>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.StyleDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.StyleDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.ColorData? ColorData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorData>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ColorDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ColorDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.LayoutNode? LayoutNode
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.LayoutNodeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.LayoutNodeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionList? DiagramDefinitionExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
