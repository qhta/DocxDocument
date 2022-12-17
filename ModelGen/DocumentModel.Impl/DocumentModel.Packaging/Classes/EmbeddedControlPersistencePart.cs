namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistencePart
/// </summary>
public class EmbeddedControlPersistencePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, EmbeddedControlPersistencePart
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
    set
    {
      if (value != null && value != _EmbeddedControlPersistenceBinaryDataParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart>().ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddPart(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart> observableCollection)
        _EmbeddedControlPersistenceBinaryDataParts = observableCollection;
      else if (value != null)
        _EmbeddedControlPersistenceBinaryDataParts = new ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>(value);
      else
       _EmbeddedControlPersistenceBinaryDataParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? _EmbeddedControlPersistenceBinaryDataParts;
  
  private void _EmbeddedControlPersistenceBinaryDataParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
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
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
