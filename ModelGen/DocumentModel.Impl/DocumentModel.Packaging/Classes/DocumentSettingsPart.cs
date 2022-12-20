namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
public partial class DocumentSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DocumentSettingsPart
{
  public new DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DocumentSettingsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocumentSettingsPartImpl(): base() {}
  
  public DocumentSettingsPartImpl(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts
  {
    get
    {
      if (_ImageParts != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>()
            .Select(item => new DocumentModel.Packaging.ImagePartImpl(item)).ToList();
          _ImageParts = new ObservableCollection<DocumentModel.Packaging.ImagePart>(items);
        }
        else
          _ImageParts = new ObservableCollection<DocumentModel.Packaging.ImagePart>();
        _ImageParts.CollectionChanged += _ImageParts_CollectionChanged;
      }
      return _ImageParts;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.ImagePart>? _ImageParts;
  
  private void _ImageParts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>().ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.ImagePartImpl valImpl)
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
              if (val is DocumentModel.Packaging.ImagePartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>()
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
  
  
  /// <summary>
  /// Gets the MailMergeRecipientDataPart of the DocumentSettingsPart
  /// </summary>
  public DocumentModel.Packaging.MailMergeRecipientDataPart? MailMergeRecipientDataPart
  {
    get
    {
      if (OpenXmlElement?.MailMergeRecipientDataPart != null)
        return new DocumentModel.Packaging.MailMergeRecipientDataPartImpl(OpenXmlElement.MailMergeRecipientDataPart);
      return null;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Settings? Settings
  {
    get
    {
      if (OpenXmlElement?.Settings != null)
        return new DocumentModel.Wordprocessing.SettingsImpl(OpenXmlElement.Settings);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.SettingsImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Settings = valueImpl.OpenXmlElement;
    }
  }
  
}
