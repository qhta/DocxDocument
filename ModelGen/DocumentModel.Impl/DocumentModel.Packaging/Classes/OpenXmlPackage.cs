namespace DocumentModel.Packaging;

/// <summary>
/// Represents a base class for strong typed Open XML document classes.
/// </summary>
public class OpenXmlPackageImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, OpenXmlPackage
{
  public new DocumentFormat.OpenXml.Packaging.OpenXmlPackage? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.OpenXmlPackage?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlPackageImpl(): base() {}
  
  public OpenXmlPackageImpl(DocumentFormat.OpenXml.Packaging.OpenXmlPackage openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets a value indicating whether this package contains Transitional relationships converted from Strict.
  /// </summary>
  public Boolean? StrictRelationshipFound
  {
    get => (System.Boolean?)OpenXmlElement?.StrictRelationshipFound;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPackage).GetProperty("StrictRelationshipFound").SetValue(OpenXmlElement, (System.Boolean?)value);
    }
  }
  
  /// <summary>
  /// Gets the package of the document.
  /// </summary>
  public Package? Package
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the FileAccess setting for the document.
  /// </summary>
  public FileAccess? FileOpenAccess
  {
    get => (System.IO.FileAccess?)OpenXmlElement?.FileOpenAccess;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPackage).GetProperty("FileOpenAccess").SetValue(OpenXmlElement, (System.IO.FileAccess?)value);
    }
  }
  
  /// <summary>
  /// Gets the core package properties of the Open XML document.
  /// </summary>
  public PackageProperties? PackageProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the compression level for the content of the new part
  /// </summary>
  public CompressionOption? CompressionOption
  {
    get => (System.IO.Packaging.CompressionOption?)OpenXmlElement?.CompressionOption;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPackage).GetProperty("CompressionOption").SetValue(OpenXmlElement, (System.IO.Packaging.CompressionOption?)value);
    }
  }
  
  /// <summary>
  /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
  /// </summary>
  public Dictionary<System.String, System.String>? PartExtensionProvider
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets all the  parts in the document package.
  /// </summary>
  public Collection<DocumentModel.Packaging.DataPart>? DataParts
  {
    get
    {
      if (_DataParts != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.DataParts
            .Select(item => new DocumentModel.Packaging.DataPartImpl(item)).ToList();
          _DataParts = new ObservableCollection<DocumentModel.Packaging.DataPart>(items);
        }
        else
          _DataParts = new ObservableCollection<DocumentModel.Packaging.DataPart>();
        _DataParts.CollectionChanged += _DataParts_CollectionChanged;
      }
      return _DataParts;
    }
    set
    {
      if (value != null && value != _DataParts && OpenXmlElement!=null)
      {
        foreach (var item in OpenXmlElement.DataParts.ToArray())
          OpenXmlElement.DeletePart(item);
        foreach (var val in value)
        {
          if (val is DocumentModel.Packaging.DataPartImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddDataPartToList(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Packaging.DataPart> observableCollection)
        _DataParts = observableCollection;
      else if (value != null)
        _DataParts = new ObservableCollection<DocumentModel.Packaging.DataPart>(value);
      else
       _DataParts = null;
    }
  }
  private ObservableCollection<DocumentModel.Packaging.DataPart>? _DataParts;
  
  private void _DataParts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          foreach (var item in OpenXmlElement.DataParts.ToArray())
            OpenXmlElement.DeletePart(item);
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Packaging.DataPartImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddDataPartToList(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Packaging.DataPartImpl valImpl)
              {
                  var oldItem = OpenXmlElement.DataParts
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
  /// Gets the markup compatibility settings applied at loading time.
  /// </summary>
  public DocumentModel.Packaging.MarkupCompatibilityProcessSettings? MarkupCompatibilityProcessSettings
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets a value indicating whether the parts should be saved when disposed.
  /// </summary>
  public Boolean? AutoSave
  {
    get => (System.Boolean?)OpenXmlElement?.AutoSave;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPackage).GetProperty("AutoSave").SetValue(OpenXmlElement, (System.Boolean?)value);
    }
  }
  
}
