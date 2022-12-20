namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Style Definition.
/// </summary>
public partial class StyleDefinitionImpl: ModelElementImpl, StyleDefinition
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StyleDefinitionImpl(): base() {}
  
  public StyleDefinitionImpl(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique Style ID
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
  /// Minimum Version
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
  /// Gets the DiagramStylePart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.DiagramStylePart? DiagramStylePart
  {
    get
    {
      if (OpenXmlElement?.DiagramStylePart != null)
        return new DocumentModel.Packaging.DiagramStylePartImpl(OpenXmlElement.DiagramStylePart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.DiagramStylePartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle>? StyleDefinitionTitles
  {
    get
    {
      if (_StyleDefinitionTitles != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>()
            .Select(item => new DocumentModel.Drawings.Diagrams.StyleDefinitionTitleImpl(item)).ToList();
          _StyleDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle>(items);
        }
        else
          _StyleDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle>();
        _StyleDefinitionTitles.CollectionChanged += _StyleDefinitionTitles_CollectionChanged;
      }
      return _StyleDefinitionTitles;
    }
    set
    {
      if (value != null && value != _StyleDefinitionTitles && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.StyleDefinitionTitleImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle> observableCollection)
        _StyleDefinitionTitles = observableCollection;
      else if (value != null)
        _StyleDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle>(value);
      else
       _StyleDefinitionTitles = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle>? _StyleDefinitionTitles;
  
  private void _StyleDefinitionTitles_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.StyleDefinitionTitleImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.StyleDefinitionTitleImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>()
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
  
  
  public Collection<DocumentModel.Drawings.Diagrams.StyleLabelDescription>? StyleLabelDescriptions
  {
    get
    {
      if (_StyleLabelDescriptions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>()
            .Select(item => new DocumentModel.Drawings.Diagrams.StyleLabelDescriptionImpl(item)).ToList();
          _StyleLabelDescriptions = new ObservableCollection<DocumentModel.Drawings.Diagrams.StyleLabelDescription>(items);
        }
        else
          _StyleLabelDescriptions = new ObservableCollection<DocumentModel.Drawings.Diagrams.StyleLabelDescription>();
        _StyleLabelDescriptions.CollectionChanged += _StyleLabelDescriptions_CollectionChanged;
      }
      return _StyleLabelDescriptions;
    }
    set
    {
      if (value != null && value != _StyleLabelDescriptions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.StyleLabelDescriptionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.StyleLabelDescription> observableCollection)
        _StyleLabelDescriptions = observableCollection;
      else if (value != null)
        _StyleLabelDescriptions = new ObservableCollection<DocumentModel.Drawings.Diagrams.StyleLabelDescription>(value);
      else
       _StyleLabelDescriptions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.StyleLabelDescription>? _StyleLabelDescriptions;
  
  private void _StyleLabelDescriptions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.StyleLabelDescriptionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.StyleLabelDescriptionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>()
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
  
  
  public DocumentModel.Drawings.Diagrams.StyleDisplayCategories? StyleDisplayCategories
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.StyleDisplayCategoriesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.StyleDisplayCategoriesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.Scene3D? Scene3D
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.Scene3DImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.Scene3DImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.StyleLabel? StyleLabel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.StyleLabelImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.StyleLabelImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
