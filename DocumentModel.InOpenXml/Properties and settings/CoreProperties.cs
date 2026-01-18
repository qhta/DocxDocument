namespace DocumentModel;
#pragma warning disable OOXML0001
/// <summary>
///   Collection of core properties, which represents document properties defined in Dublin Core standard
/// and Open Packaging Conventions
/// </summary>
[OpenXmlType(typeof(PackageProperties))]
public partial class CoreProperties : ModelElement
{
  /// <summary>
  /// Gets the underlying WordprocessingDocument instance associated with this object.
  /// </summary>
  internal DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

  internal PackageProperties? PackageProperties { get; private set; }

  /// <summary>
  /// Default constructor.
  /// </summary>
  public CoreProperties()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public CoreProperties(Wordprocessing.Document document)
  {
    AttachAndLoad(document);
  }

  /// <summary>
  /// Retrieves the Open XML element that represents the updatable package properties for the current instance.
  /// </summary>
  /// <returns>An object representing the updatable Open XML package properties, or <see langword="null"/> if no properties are
  /// available.</returns>
  protected override object? GetUpdatableOpenXmlElement()
  {
    return PackageProperties;
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is loaded from the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndLoad(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var packageProperties = document.WordprocessingDocument?.GetPackageProperties();
    if (packageProperties != null)
    {
      PackageProperties = packageProperties;
      LoadData(packageProperties);
    }
  }

  /// <summary>
  /// Populates the properties of the current instance with values from the specified Open XML element.
  /// </summary>
  /// <remarks>This method matches properties by name between the Open XML element and the current instance.
  /// Only writable properties are set. Type conversion is performed if the property types do not match
  /// exactly.</remarks>
  /// <param name="openXmlElement">The Open XML element containing property values to load. Must be an instance of the expected Open XML type.</param>
  public override void LoadData(object openXmlElement)
  {
    var currentType = GetType();
    var openXmlType = typeof(PackageProperties);
    foreach (var openXmlProperty in openXmlType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
    {
      var modelProperty = currentType.GetProperty(openXmlProperty.Name);
      if (modelProperty != null && modelProperty.CanWrite)
      {
        var openXmlValue = openXmlProperty.GetValue(openXmlElement);
        if (!modelProperty.PropertyType.IsInstanceOfType(openXmlValue))
          openXmlValue = OpenXmlConverter.ConvertToOpenXml(openXmlValue, modelProperty.PropertyType.GetNotNullableType());
        modelProperty.SetValue(this, openXmlValue);
      }
    }
  }

  /// <summary>
  /// Updates the specified Open XML element with the current property values of this instance.
  /// </summary>
  /// <remarks>This method maps the public instance properties of the current object to properties of the Open
  /// XML element with matching names. Only properties that exist and are writable on the Open XML element are updated.
  /// Property values are converted to the appropriate Open XML types as needed.</remarks>
  /// <param name="openXmlElement">The Open XML element to update. Must be an instance of the expected Open XML type that supports writable
  /// properties corresponding to this model.</param>
  public override void UpdateData(object openXmlElement)
  {
    var currentType = GetType();
    var openXmlType = typeof(PackageProperties);
    foreach (var modelProperty in currentType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
    {
      var openXmlProperty = openXmlType.GetProperty(modelProperty.Name);
      if (openXmlProperty != null && openXmlProperty.CanWrite)
      {
        var modelValue = modelProperty.GetValue(this);
        if (!openXmlProperty.PropertyType.IsInstanceOfType(modelValue))
          modelValue = OpenXmlConverter.ConvertToOpenXml(modelValue, openXmlProperty.PropertyType);
        openXmlProperty.SetValue(openXmlElement, modelValue);
      }
    }
  }

  /// <summary>
  /// Updates the corresponding Open XML property with the current value of the specified model property.
  /// </summary>
  /// <remarks>If the property value is not directly compatible with the Open XML property type, it will be
  /// converted before assignment. No action is taken if the specified property does not exist or cannot be
  /// updated.</remarks>
  /// <param name="propertyName">The name of the model property whose value will be synchronized to the Open XML property. Must correspond to a
  /// property defined on this instance.</param>
  public override void UpdatePropertyData(string propertyName)
  {
    var openXmlElement = GetUpdatableOpenXmlElement();
    if (openXmlElement == null)
      return;
    var modelProperty = this.GetType().GetProperty(propertyName);
    if (modelProperty == null) return;
    var openXmlType = typeof(PackageProperties);
    var openXmlProperty = openXmlType.GetProperty(modelProperty.Name);
    if (openXmlProperty == null) return;
    var modelValue = modelProperty.GetValue(this);
    if (!openXmlProperty.PropertyType.IsInstanceOfType(modelValue))
      modelValue = OpenXmlConverter.ConvertToOpenXml(modelValue, openXmlProperty.PropertyType);
    openXmlProperty.SetValue(openXmlElement, modelValue);
  }

  /// <summary>
  /// Copies data from the specified CoreProperties instance to this instance.
  /// </summary>
  /// <param name="properties">CoreProperties instance containing the model property value.</param>
  public void CopyFrom(CoreProperties properties)
  {
    var currentType = properties.GetType();
    foreach (var modelProperty in currentType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
    {
      var value = modelProperty.GetValue(properties);
      modelProperty.SetValue(this, value);
    }
    var updatableElement = GetUpdatableOpenXmlElement();
    if (updatableElement != null)
      UpdateData(updatableElement);
  }


  /// <summary>
  /// Detach this instance from the specified document.
  /// Underlying Open XML element is set to null, so further access to its properties will not work until re-attached.
  /// </summary>
  /// <param name="document">Document to detach from. Must be the same as the one attached.</param>
  public void Detach(Wordprocessing.Document document)
  {
    if (WordprocessingDocument != document.WordprocessingDocument)
      return;
    WordprocessingDocument = null;
    PackageProperties = null;
  }

}