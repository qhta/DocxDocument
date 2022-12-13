namespace DocumentModel.Drawings;

/// <summary>
/// Style Definition.
/// </summary>
public class StyleDefinitionImpl: ModelElementImpl, StyleDefinition
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
  
  public Collection<DocumentModel.Drawings.StyleDefinitionTitle>? StyleDefinitionTitles
  {
    get
    {
      if (_StyleDefinitionTitles != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>()
            .Select(item => new DocumentModel.Drawings.StyleDefinitionTitleImpl(item)).ToList();
          _StyleDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.StyleDefinitionTitle>(items);
        }
        else
          _StyleDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.StyleDefinitionTitle>();
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
        if (val is DocumentModel.Drawings.StyleDefinitionTitleImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.StyleDefinitionTitle> observableCollection)
        _StyleDefinitionTitles = observableCollection;
      else if (value != null)
        _StyleDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.StyleDefinitionTitle>(value);
      else
       _StyleDefinitionTitles = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.StyleDefinitionTitle>? _StyleDefinitionTitles;
  
  private void _StyleDefinitionTitles_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.StyleDefinitionTitleImpl valImpl)
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
        if (val is DocumentModel.Drawings.StyleDefinitionTitleImpl valImpl)
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
  
  
  public Collection<DocumentModel.Drawings.StyleLabelDescription>? StyleLabelDescriptions
  {
    get
    {
      if (_StyleLabelDescriptions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>()
            .Select(item => new DocumentModel.Drawings.StyleLabelDescriptionImpl(item)).ToList();
          _StyleLabelDescriptions = new ObservableCollection<DocumentModel.Drawings.StyleLabelDescription>(items);
        }
        else
          _StyleLabelDescriptions = new ObservableCollection<DocumentModel.Drawings.StyleLabelDescription>();
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
        if (val is DocumentModel.Drawings.StyleLabelDescriptionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.StyleLabelDescription> observableCollection)
        _StyleLabelDescriptions = observableCollection;
      else if (value != null)
        _StyleLabelDescriptions = new ObservableCollection<DocumentModel.Drawings.StyleLabelDescription>(value);
      else
       _StyleLabelDescriptions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.StyleLabelDescription>? _StyleLabelDescriptions;
  
  private void _StyleLabelDescriptions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.StyleLabelDescriptionImpl valImpl)
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
        if (val is DocumentModel.Drawings.StyleLabelDescriptionImpl valImpl)
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
  
  
  public DocumentModel.Drawings.StyleDisplayCategories? StyleDisplayCategories
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Scene3D? Scene3D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.StyleLabel? StyleLabel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
