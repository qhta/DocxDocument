namespace DocumentModel;

/// <summary>
///   Predefined set of metadata properties that are applicable to Office Open XML documents. 
///   These properties extend the set of core properties which are common to all packages.
/// </summary>
[OpenXmlType(typeof(DXEP.Properties))]
public sealed partial class ContentProperties : ModelElement<DXEP.Properties>
{

  /// <summary>
  /// Gets the underlying Document instance associated with this object.
  /// </summary>

  static ContentProperties()
  {
    RegisterOpenXmlConversion();
  }


  /// <summary>
  /// Default constructor.
  /// </summary>
  public ContentProperties()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public ContentProperties(Wordprocessing.Document document)
  {
    if (document.WordprocessingDocument != null)
      AttachAndLoad(document.WordprocessingDocument);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is loaded from the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public override void AttachAndLoad(DXPP.WordprocessingDocument document)
  {
    base.AttachAndLoad(document);
    var extendedFileProperties = document.GetExtendedFileProperties();
    SetUpdatableElement(extendedFileProperties);
    LoadData(extendedFileProperties);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public override void AttachAndUpdate(DXPP.WordprocessingDocument document)
  {
    base.AttachAndUpdate(document);
    var extendedFileProperties = document.GetExtendedFileProperties();
    SetUpdatableElement(extendedFileProperties);
    UpdateData(extendedFileProperties);
  }

  /// <summary>
  /// Detach this instance from the attached document.
  /// Underlying Open XML element is set to null, so further access to its properties will not work until re-attached.
  /// </summary>
  public override void Detach()
  {
    base.Detach();
    SetUpdatableElement(null);
  }

}