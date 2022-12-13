namespace DocumentModel.Drawings;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public class ColorsDefinitionImpl: ModelElementImpl, ColorsDefinition
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  
  public Collection<DocumentModel.Drawings.ColorDefinitionTitle>? ColorDefinitionTitles
  {
    get
    {
      if (_ColorDefinitionTitles != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>()
            .Select(item => new DocumentModel.Drawings.ColorDefinitionTitleImpl(item)).ToList();
          _ColorDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.ColorDefinitionTitle>(items);
        }
        else
          _ColorDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.ColorDefinitionTitle>();
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
        if (val is DocumentModel.Drawings.ColorDefinitionTitleImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ColorDefinitionTitle> observableCollection)
        _ColorDefinitionTitles = observableCollection;
      else if (value != null)
        _ColorDefinitionTitles = new ObservableCollection<DocumentModel.Drawings.ColorDefinitionTitle>(value);
      else
       _ColorDefinitionTitles = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ColorDefinitionTitle>? _ColorDefinitionTitles;
  
  private void _ColorDefinitionTitles_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.ColorDefinitionTitleImpl valImpl)
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
        if (val is DocumentModel.Drawings.ColorDefinitionTitleImpl valImpl)
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
  
  
  public Collection<DocumentModel.Drawings.ColorTransformDescription>? ColorTransformDescriptions
  {
    get
    {
      if (_ColorTransformDescriptions != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>()
            .Select(item => new DocumentModel.Drawings.ColorTransformDescriptionImpl(item)).ToList();
          _ColorTransformDescriptions = new ObservableCollection<DocumentModel.Drawings.ColorTransformDescription>(items);
        }
        else
          _ColorTransformDescriptions = new ObservableCollection<DocumentModel.Drawings.ColorTransformDescription>();
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
        if (val is DocumentModel.Drawings.ColorTransformDescriptionImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ColorTransformDescription> observableCollection)
        _ColorTransformDescriptions = observableCollection;
      else if (value != null)
        _ColorTransformDescriptions = new ObservableCollection<DocumentModel.Drawings.ColorTransformDescription>(value);
      else
       _ColorTransformDescriptions = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ColorTransformDescription>? _ColorTransformDescriptions;
  
  private void _ColorTransformDescriptions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.ColorTransformDescriptionImpl valImpl)
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
        if (val is DocumentModel.Drawings.ColorTransformDescriptionImpl valImpl)
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
  
  
  public DocumentModel.Drawings.ColorTransformCategories? ColorTransformCategories
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Drawings.ColorTransformStyleLabel>? ColorTransformStyleLabels
  {
    get
    {
      if (_ColorTransformStyleLabels != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>()
            .Select(item => new DocumentModel.Drawings.ColorTransformStyleLabelImpl(item)).ToList();
          _ColorTransformStyleLabels = new ObservableCollection<DocumentModel.Drawings.ColorTransformStyleLabel>(items);
        }
        else
          _ColorTransformStyleLabels = new ObservableCollection<DocumentModel.Drawings.ColorTransformStyleLabel>();
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
        if (val is DocumentModel.Drawings.ColorTransformStyleLabelImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ColorTransformStyleLabel> observableCollection)
        _ColorTransformStyleLabels = observableCollection;
      else if (value != null)
        _ColorTransformStyleLabels = new ObservableCollection<DocumentModel.Drawings.ColorTransformStyleLabel>(value);
      else
       _ColorTransformStyleLabels = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ColorTransformStyleLabel>? _ColorTransformStyleLabels;
  
  private void _ColorTransformStyleLabels_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.ColorTransformStyleLabelImpl valImpl)
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
        if (val is DocumentModel.Drawings.ColorTransformStyleLabelImpl valImpl)
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
  
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
