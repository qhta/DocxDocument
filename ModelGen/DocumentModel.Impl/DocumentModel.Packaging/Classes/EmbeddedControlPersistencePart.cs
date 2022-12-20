namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistencePart
/// </summary>
public partial class EmbeddedControlPersistencePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, EmbeddedControlPersistencePart
{
  public new DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EmbeddedControlPersistencePartImpl(): base() {}
  
  public EmbeddedControlPersistencePartImpl(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts
  {
    get
    {
      if (_EmbeddedControlPersistenceBinaryDataParts != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart>()
            .Select(item => new DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPartImpl(item)).ToList();
          _EmbeddedControlPersistenceBinaryDataParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>(items);
        }
        else
          _EmbeddedControlPersistenceBinaryDataParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>();
        _EmbeddedControlPersistenceBinaryDataParts.CollectionChanged += _EmbeddedControlPersistenceBinaryDataParts_CollectionChanged;
      }
      return _EmbeddedControlPersistenceBinaryDataParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? _EmbeddedControlPersistenceBinaryDataParts;
  
  private void _EmbeddedControlPersistenceBinaryDataParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddPart(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    OpenXmlElement.DeletePart(oldItem);
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
