namespace DocumentModel;

/// <summary>
///   Custom-defined document property.
/// </summary>
[OpenXmlType(typeof(DXCP.CustomDocumentProperty))]
public sealed partial class CustomProperty: ModelElement<DXCP.CustomDocumentProperty>
{
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  private DXCP.CustomDocumentProperty? OpenXmlCustomDocumentProperty
  {
    get => GetUpdatableElement() as DXCP.CustomDocumentProperty; 
    set => SetUpdatableElement(value);
  }

  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  public CustomProperty(): base()
  {
  }

  /// <summary>
  /// Initialization constructor.
  /// </summary>
  /// <param name = "propertiesCollection">Collection that contains this property</param>
  /// <param name = "openXmlCustomDocumentProperty">Element from the Open XML SDK representing a custom document property.</param>
  public CustomProperty
  (CustomProperties propertiesCollection,
    DXCP.CustomDocumentProperty openXmlCustomDocumentProperty) //: base(propertiesCollection)
  {
    SetUpdatableElement(openXmlCustomDocumentProperty);
    LoadData(openXmlCustomDocumentProperty);
  }

  /// <summary>
  /// Creates and initializes an open custom document property based on the current state of the object.
  /// </summary>
  /// <remarks>If the custom document property has already been created, this method returns the existing
  /// instance. Otherwise, it creates a new property and initializes it with the current values.</remarks>
  /// <returns>A <see cref = "DXCP.CustomDocumentProperty"/> instance representing the open custom document property with values set
  /// from the current object.</returns>
  public DXCP.CustomDocumentProperty CreateOpenCustomDocumentProperty()
  {
    OpenXmlCustomDocumentProperty ??= new DXCP.CustomDocumentProperty();
    UpdateData(OpenXmlCustomDocumentProperty);
    return OpenXmlCustomDocumentProperty!;
  }
}