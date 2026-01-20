namespace DocumentModel;

/// <summary>
///   Predefined set of metadata properties that are applicable to Office Open XML documents. 
///   These properties extend the set of core properties which are common to all packages.
/// </summary>
[OpenXmlType(typeof(DXEP.Properties))]
public partial class ContentProperties : ModelElement<DXEP.Properties>
{

  /// <summary>
  /// Gets the underlying Document instance associated with this object.
  /// </summary>
  internal DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

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
  public void AttachAndLoad(DXPack.WordprocessingDocument document)
  {
    WordprocessingDocument = document;
    var extendedFileProperties = document.GetExtendedFileProperties();
    SetOpenXmlElement(extendedFileProperties);
    LoadData(extendedFileProperties);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndUpdate(DXPack.WordprocessingDocument document)
  {
    WordprocessingDocument = document;
    var extendedFileProperties = document.GetExtendedFileProperties();
    SetOpenXmlElement(extendedFileProperties);
    UpdateData(extendedFileProperties);
  }

  /// <summary>
  /// Detach this instance from the attached document.
  /// Underlying Open XML element is set to null, so further access to its properties will not work until re-attached.
  /// </summary>
  public void Detach()
  {
    WordprocessingDocument = null;
    SetOpenXmlElement(null);
  }

  public override void UpdatePropertyData(string propertyName)
  {
    base.UpdatePropertyData(propertyName);
  }
}