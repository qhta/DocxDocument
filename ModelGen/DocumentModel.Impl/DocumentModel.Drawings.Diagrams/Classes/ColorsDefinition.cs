namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public partial class ColorsDefinitionImpl: ModelElementImpl, ColorsDefinition
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ColorsDefinitionImpl(): base() {}
  
  public ColorsDefinitionImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique ID
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
  
  public Collection<DocumentModel.Drawings.Diagrams.ColorDefinitionTitle>? ColorDefinitionTitles
  {
    get
    {
      if (_ColorDefinitionTitles == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>()
            .Select(item => new DocumentModel.Drawings.Diagrams.ColorDefinitionTitleImpl(item)).ToList();
          _ColorDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorDefinitionTitle>(items);
        }
        else
          _ColorDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorDefinitionTitle>();
        _ColorDefinitionTitles.CollectionChanged += _ColorDefinitionTitles_CollectionChanged;
      }
      return _ColorDefinitionTitles;
    }
    set
    {
      if (value != null && value != _ColorDefinitionTitles && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.ColorDefinitionTitleImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.ColorDefinitionTitle> observableCollection)
        _ColorDefinitionTitles = observableCollection;
      else if (value != null)
        _ColorDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorDefinitionTitle>(value);
      else
       _ColorDefinitionTitles = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.ColorDefinitionTitle>? _ColorDefinitionTitles;
  
  private void _ColorDefinitionTitles_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.ColorDefinitionTitleImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.ColorDefinitionTitleImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>()
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
  
  
  public Collection<DocumentModel.Drawings.Diagrams.ColorTransformDescription>? ColorTransformDescriptions
  {
    get
    {
      if (_ColorTransformDescriptions == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>()
            .Select(item => new DocumentModel.Drawings.Diagrams.ColorTransformDescriptionImpl(item)).ToList();
          _ColorTransformDescriptions = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformDescription>(items);
        }
        else
          _ColorTransformDescriptions = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformDescription>();
        _ColorTransformDescriptions.CollectionChanged += _ColorTransformDescriptions_CollectionChanged;
      }
      return _ColorTransformDescriptions;
    }
    set
    {
      if (value != null && value != _ColorTransformDescriptions && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.ColorTransformDescriptionImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformDescription> observableCollection)
        _ColorTransformDescriptions = observableCollection;
      else if (value != null)
        _ColorTransformDescriptions = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformDescription>(value);
      else
       _ColorTransformDescriptions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformDescription>? _ColorTransformDescriptions;
  
  private void _ColorTransformDescriptions_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.ColorTransformDescriptionImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.ColorTransformDescriptionImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>()
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
  
  
  public DocumentModel.Drawings.Diagrams.ColorTransformCategories? ColorTransformCategories
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ColorTransformCategoriesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ColorTransformCategoriesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel>? ColorTransformStyleLabels
  {
    get
    {
      if (_ColorTransformStyleLabels == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>()
            .Select(item => new DocumentModel.Drawings.Diagrams.ColorTransformStyleLabelImpl(item)).ToList();
          _ColorTransformStyleLabels = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel>(items);
        }
        else
          _ColorTransformStyleLabels = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel>();
        _ColorTransformStyleLabels.CollectionChanged += _ColorTransformStyleLabels_CollectionChanged;
      }
      return _ColorTransformStyleLabels;
    }
    set
    {
      if (value != null && value != _ColorTransformStyleLabels && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.ColorTransformStyleLabelImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel> observableCollection)
        _ColorTransformStyleLabels = observableCollection;
      else if (value != null)
        _ColorTransformStyleLabels = new ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel>(value);
      else
       _ColorTransformStyleLabels = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel>? _ColorTransformStyleLabels;
  
  private void _ColorTransformStyleLabels_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.ColorTransformStyleLabelImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.ColorTransformStyleLabelImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>()
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
