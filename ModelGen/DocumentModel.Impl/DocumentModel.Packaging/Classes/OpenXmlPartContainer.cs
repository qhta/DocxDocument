namespace DocumentModel.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public class OpenXmlPartContainerImpl: ModelObjectImpl, OpenXmlPartContainer
{
  public DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlPartContainerImpl(): base() {}
  
  public OpenXmlPartContainerImpl(DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets all external relationships.
  /// </summary>
  public Collection<DocumentModel.Packaging.ExternalRelationship>? ExternalRelationships
  {
    get
    {
      if (_ExternalRelationships != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.ExternalRelationships
            .Select(item => new DocumentModel.Packaging.ExternalRelationshipImpl(item)).ToList();
          _ExternalRelationships = new ObservableCollection<DocumentModel.Packaging.ExternalRelationship>(items);
        }
        else
          _ExternalRelationships = new ObservableCollection<DocumentModel.Packaging.ExternalRelationship>();
        _ExternalRelationships.CollectionChanged += _ExternalRelationships_CollectionChanged;
      }
      return _ExternalRelationships;
    }
    set
    {
      if (value != null && value != _ExternalRelationships && OpenXmlElement!=null)
      {
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.ExternalRelationshipImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              if (!OpenXmlElement.ExternalRelationships.Contains(item))
                OpenXmlElement.AddExternalRelationship(item.RelationshipType, item.Uri, item.Id);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.ExternalRelationship> observableCollection)
        _ExternalRelationships = observableCollection;
      else if (value != null)
        _ExternalRelationships = new ObservableCollection<DocumentModel.Packaging.ExternalRelationship>(value);
      else
       _ExternalRelationships = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ExternalRelationship>? _ExternalRelationships;
  
  private void _ExternalRelationships_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.ExternalRelationships.ToArray())
            OpenXmlElement.DeleteReferenceRelationship(item);
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.ExternalRelationshipImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddExternalRelationship(item.RelationshipType, item.Uri, item.Id);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
            if (val is DocumentModel.Packaging.ExternalRelationshipImpl valImpl)
            {
                if (valImpl.OpenXmlElement is DocumentFormat.OpenXml.Packaging.ExternalRelationship oldItem)
                  OpenXmlElement.DeleteReferenceRelationship(oldItem);
            };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets all hyperlink relationships.
  /// </summary>
  public Collection<DocumentModel.Packaging.HyperlinkRelationship>? HyperlinkRelationships
  {
    get
    {
      if (_HyperlinkRelationships != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.HyperlinkRelationships
            .Select(item => new DocumentModel.Packaging.HyperlinkRelationshipImpl(item)).ToList();
          _HyperlinkRelationships = new ObservableCollection<DocumentModel.Packaging.HyperlinkRelationship>(items);
        }
        else
          _HyperlinkRelationships = new ObservableCollection<DocumentModel.Packaging.HyperlinkRelationship>();
        _HyperlinkRelationships.CollectionChanged += _HyperlinkRelationships_CollectionChanged;
      }
      return _HyperlinkRelationships;
    }
    set
    {
      if (value != null && value != _HyperlinkRelationships && OpenXmlElement!=null)
      {
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.HyperlinkRelationshipImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              if (!OpenXmlElement.HyperlinkRelationships.Contains(item))
                OpenXmlElement.AddHyperlinkRelationship(item.Uri, item.IsExternal, item.Id);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.HyperlinkRelationship> observableCollection)
        _HyperlinkRelationships = observableCollection;
      else if (value != null)
        _HyperlinkRelationships = new ObservableCollection<DocumentModel.Packaging.HyperlinkRelationship>(value);
      else
       _HyperlinkRelationships = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.HyperlinkRelationship>? _HyperlinkRelationships;
  
  private void _HyperlinkRelationships_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.HyperlinkRelationships.ToArray())
            OpenXmlElement.DeleteReferenceRelationship(item);
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.HyperlinkRelationshipImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddHyperlinkRelationship(item.Uri, item.IsExternal, item.Id);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
            if (val is DocumentModel.Packaging.HyperlinkRelationshipImpl valImpl)
            {
                if (valImpl.OpenXmlElement is DocumentFormat.OpenXml.Packaging.HyperlinkRelationship oldItem)
                  OpenXmlElement.DeleteReferenceRelationship(oldItem);
            };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets all  relationships.
  /// </summary>
  public Collection<DocumentModel.Packaging.DataPartReferenceRelationship>? DataPartReferenceRelationships
  {
    get
    {
      if (_DataPartReferenceRelationships != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.DataPartReferenceRelationships
            .Select(item => new DocumentModel.Packaging.DataPartReferenceRelationshipImpl(item)).ToList();
          _DataPartReferenceRelationships = new ObservableCollection<DocumentModel.Packaging.DataPartReferenceRelationship>(items);
        }
        else
          _DataPartReferenceRelationships = new ObservableCollection<DocumentModel.Packaging.DataPartReferenceRelationship>();
        _DataPartReferenceRelationships.CollectionChanged += _DataPartReferenceRelationships_CollectionChanged;
      }
      return _DataPartReferenceRelationships;
    }
    set
    {
      if (value != null && value != _DataPartReferenceRelationships && OpenXmlElement!=null)
      {
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.DataPartReferenceRelationshipImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              if (!OpenXmlElement.DataPartReferenceRelationships.Contains(item))
                OpenXmlElement.AddDataPartReferenceRelationship(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.DataPartReferenceRelationship> observableCollection)
        _DataPartReferenceRelationships = observableCollection;
      else if (value != null)
        _DataPartReferenceRelationships = new ObservableCollection<DocumentModel.Packaging.DataPartReferenceRelationship>(value);
      else
       _DataPartReferenceRelationships = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DataPartReferenceRelationship>? _DataPartReferenceRelationships;
  
  private void _DataPartReferenceRelationships_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.DataPartReferenceRelationships.ToArray())
            OpenXmlElement.DeleteReferenceRelationship(item);
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.DataPartReferenceRelationshipImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddDataPartReferenceRelationship(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
            if (val is DocumentModel.Packaging.DataPartReferenceRelationshipImpl valImpl)
            {
                if (valImpl.OpenXmlElement is DocumentFormat.OpenXml.Packaging.DataPartReferenceRelationship oldItem)
                  OpenXmlElement.DeleteReferenceRelationship(oldItem);
            };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  /// <summary>
  /// Gets all parts which are relationship targets of this part.
  /// </summary>
  public Collection<DocumentModel.Packaging.IdPartPair>? Parts
  {
    get
    {
      if (_Parts != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Parts
            .Select(item => new DocumentModel.Packaging.IdPartPairImpl(item)).ToList();
          _Parts = new ObservableCollection<DocumentModel.Packaging.IdPartPair>(items);
        }
        else
          _Parts = new ObservableCollection<DocumentModel.Packaging.IdPartPair>();
        _Parts.CollectionChanged += _Parts_CollectionChanged;
      }
      return _Parts;
    }
    set
    {
      if (value != null && value != _Parts && OpenXmlElement!=null)
      {
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.IdPartPairImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              if (!OpenXmlElement.Parts.Contains(item))
                OpenXmlElement.AddPart(item.OpenXmlPart, item.RelationshipId);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.IdPartPair> observableCollection)
        _Parts = observableCollection;
      else if (value != null)
        _Parts = new ObservableCollection<DocumentModel.Packaging.IdPartPair>(value);
      else
       _Parts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.IdPartPair>? _Parts;
  
  private void _Parts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.Parts.ToArray())
            OpenXmlElement.DeletePart(item.RelationshipId);
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.IdPartPairImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
              OpenXmlElement.AddPart(item.OpenXmlPart, item.RelationshipId);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
            if (val is DocumentModel.Packaging.IdPartPairImpl valImpl)
            {
                if (valImpl.OpenXmlElement is DocumentFormat.OpenXml.Packaging.IdPartPair oldItem)
                  OpenXmlElement.DeletePart(oldItem.RelationshipId);
            };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
}
