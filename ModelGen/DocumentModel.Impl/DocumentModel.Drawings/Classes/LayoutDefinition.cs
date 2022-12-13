namespace DocumentModel.Drawings;

/// <summary>
/// Layout Definition.
/// </summary>
public class LayoutDefinitionImpl: ModelElementImpl, LayoutDefinition
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
  
  public Collection<DocumentModel.Drawings.Title>? Titles
  {
    get
    {
      if (_Titles != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Title>()
            .Select(item => new DocumentModel.Drawings.TitleImpl(item)).ToList();
          _Titles = new ObservableCollection<DocumentModel.Drawings.Title>(items);
        }
        else
          _Titles = new ObservableCollection<DocumentModel.Drawings.Title>();
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
        if (val is DocumentModel.Drawings.TitleImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Title> observableCollection)
        _Titles = observableCollection;
      else if (value != null)
        _Titles = new ObservableCollection<DocumentModel.Drawings.Title>(value);
      else
       _Titles = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Title>? _Titles;
  
  private void _Titles_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Title>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.TitleImpl valImpl)
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
        if (val is DocumentModel.Drawings.TitleImpl valImpl)
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
  
  
  public Collection<DocumentModel.Drawings.Description>? Descriptions
  {
    get
    {
      if (_Descriptions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Description>()
            .Select(item => new DocumentModel.Drawings.DescriptionImpl(item)).ToList();
          _Descriptions = new ObservableCollection<DocumentModel.Drawings.Description>(items);
        }
        else
          _Descriptions = new ObservableCollection<DocumentModel.Drawings.Description>();
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
        if (val is DocumentModel.Drawings.DescriptionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Description> observableCollection)
        _Descriptions = observableCollection;
      else if (value != null)
        _Descriptions = new ObservableCollection<DocumentModel.Drawings.Description>(value);
      else
       _Descriptions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Description>? _Descriptions;
  
  private void _Descriptions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Description>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.DescriptionImpl valImpl)
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
        if (val is DocumentModel.Drawings.DescriptionImpl valImpl)
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
  
  
  public DocumentModel.Drawings.CategoryList? CategoryList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.SampleData? SampleData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.StyleData? StyleData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.ColorData? ColorData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.LayoutNode? LayoutNode
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.DiagramDefinitionExtensionList? DiagramDefinitionExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
