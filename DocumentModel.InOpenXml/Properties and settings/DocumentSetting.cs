namespace DocumentModel;
/// <summary>
///   Document setting property. Its type is taken from OpenXml element containing the OpenXml wordprocessing settings.
/// </summary>

public class DocumentSetting : DocumentProperty
{

  /// <summary>
  /// The underlying Open XML setting associated with this instance.
  /// </summary>
  internal DX.OpenXmlElement? OpenXmlSetting { get; private set; }

  /// <summary>
  /// Type of Open XML setting, if available.
  /// </summary>
  internal Type? OpenXmlSettingType { get; private set; }

  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  public DocumentSetting() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="CustomDocumentPropertyClass"/> class.
  /// </summary>
  /// <param name="propertiesCollection">Collection that contains this property</param>
  /// <param name="openXmlDocumentSetting">Element from the Open XML SDK representing a document setting.</param>
  public DocumentSetting(DocumentSettings propertiesCollection,
    DX.OpenXmlElement openXmlDocumentSetting) //: base(propertiesCollection)
  {
    OpenXmlSetting = openXmlDocumentSetting;
    OpenXmlSettingType = openXmlDocumentSetting.GetType();
  }

  /// <summary>
  /// Creates an appropriate OpenXml element  based on the current state of the object.
  /// </summary>
  /// <remarks>It creates a new OpenXml element and initializes it with the current values.</remarks>
  /// <returns>A <see cref="DX.OpenXmlElement"/> instance representing the value of this property with values set
  /// from the current object.
  /// If the <paramref name="openXmlSettingType"/> is a subclass of <see cref="DXWP.EmptyType"/>
  /// and the value of this property is null or false, the result is null.</returns>
  public DX.OpenXmlElement? CreateOpenCustomDocumentProperty(Type openXmlSettingType)
  {
    if (openXmlSettingType.IsSubclassOf(typeof(DXWP.EmptyType)))
    {
      if (Value == null)
        return null;
      if (Value?.ToBoolean() == false)
        return null;
      if (Value?.ToBoolean() == true)
        return (DX.OpenXmlElement)Activator.CreateInstance(OpenXmlSettingType!)!;
      throw new InvalidOperationException($"Value of {Value} can't be converted to OpenXmlSettingType");
    }
    OpenXmlSetting ??= (DX.OpenXmlElement)Activator.CreateInstance(OpenXmlSettingType!)!;
    SetValueToOpenXmlProperty(OpenXmlSetting);
    return OpenXmlSetting;
  }

  /// <summary>
  /// Gets value from OpenXml element to this instance.
  /// </summary>
  private void GetValueFromOpenXmlProperty(DX.OpenXmlElement openXmlCustomDocumentProperty)
  {
    foreach (var propertyInfo in typeof(CustomProperty).GetProperties())
    {
      var value = propertyInfo.GetValue(openXmlCustomDocumentProperty);
      propertyInfo.SetValue(this, value);
    }
  }

  /// <summary>
  /// Sets the value to the specified OpenXml element.
  /// </summary>
  private void SetValueToOpenXmlProperty(DX.OpenXmlElement openXmlSettingElement)
  {
    if (openXmlSettingElement is DX.OpenXmlLeafElement leafElement)
      SetValueToOpenXmlProperty(leafElement);
    else if (openXmlSettingElement is DX.OpenXmlCompositeElement compositeElement)
      SetValueToOpenXmlProperty(compositeElement);
  }

  /// <summary>
  /// Sets the value of this setting to the corresponding properties of the specified
  /// of the specified OpenXml leaf element.
  /// </summary>
  private void SetValueToOpenXmlProperty(DX.OpenXmlLeafElement openXmlSettingElement)
  {
    if (openXmlSettingElement is DXWP.OnOffType onOffTypeElement)
      onOffTypeElement.Val = Value?.ToBoolean();
    else
    if (openXmlSettingElement is DXWP.StringType stringTypeElement)
      stringTypeElement.Val = Value?.ToString();
    else
    if (openXmlSettingElement is DXWP.NonNegativeShortType nonNegativeShortTypeElement)
      nonNegativeShortTypeElement.Val = (Int16?)(Value?.ToUInt16());
    else
    {
      foreach (var propertyInfo in typeof(CustomProperty).GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
      {
        if (propertyInfo.PropertyType == typeof(DX.StringValue))
          continue;
        var value = propertyInfo.GetValue(this);
        propertyInfo.SetValue(openXmlSettingElement, value);
      }
    }
  }

  /// <summary>
  /// Sets the value of this setting to the corresponding properties of the specified
  /// OpenXml composite element.
  /// </summary>
  private void SetValueToOpenXmlProperty(DX.OpenXmlCompositeElement openXmlSettingElement)
  {
    foreach (var propertyInfo in typeof(CustomProperty).GetProperties())
    {
      var value = propertyInfo.GetValue(this);
      propertyInfo.SetValue(openXmlSettingElement, value);
    }
  }
}