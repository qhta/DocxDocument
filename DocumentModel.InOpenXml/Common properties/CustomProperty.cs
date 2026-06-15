using Qhta.OpenXmlTools;

namespace DocumentModel;
/// <summary>
///   Custom-defined document property.
/// </summary>
[OpenXmlType(typeof(DXCP.CustomDocumentProperty))]
[XmlRoot("CustomProperty", Namespace = "DocumentModel")]
[JsonConverter(typeof(CustomPropertyJsonConverter))]
public sealed partial class CustomProperty : DocumentProperty
{

  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  public CustomProperty() : base()
  {
  }

  private DXCP.CustomDocumentProperty? _OpenXmlCustomProperty;
  

  /// <summary>
  /// Initialization constructor.
  /// </summary>
  /// <param name = "propertiesCollection">Collection that contains this property</param>
  /// <param name = "openXmlOpenXmlCustomProperty">Element from the Open XML SDK representing a custom document property.</param>
  public CustomProperty(CustomProperties propertiesCollection, DXCP.CustomDocumentProperty openXmlOpenXmlCustomProperty) : this()
  {
    SetCollection(propertiesCollection);
    _OpenXmlCustomProperty = openXmlOpenXmlCustomProperty;
    LoadData(openXmlOpenXmlCustomProperty);
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
    _OpenXmlCustomProperty ??= new DXCP.CustomDocumentProperty();
    UpdateData(_OpenXmlCustomProperty);
    return _OpenXmlCustomProperty!;
  }

  /// <summary>
  ///   Property identifier. Should be unique within the document properties.
  ///   In OpenXml property identifiers start from 2.
  /// </summary>
  [OpenXmlProperty(nameof(DXCP.CustomDocumentProperty.PropertyId))]
  public int? PropertyId { get => _PropertyId; set => UpdateField(ref _PropertyId, value, nameof(PropertyId)); }
  private int? _PropertyId;

  /// <summary>
  /// Format identifier (FormatId) for the custom document property in OpenXml.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The <b>FormatId</b> is a GUID string that specifies the data type of the custom property value,
  /// such as string, integer, boolean, or date. This identifier allows applications to interpret
  /// the property's value correctly.
  /// </para>
  /// <para>
  /// Common FormatId value is:
  /// <c>{D5CDD505-2E9C-101B-9397-08002B2CF9AE}</c> - which is used for most types (string, int, double, date, bool, etc.).
  ///    The actual type is determined by the value element (e.g., &lt;vt:lpwstr&gt;, &lt;vt:i4&gt;, &lt;vt:filetime&gt;)
  /// </para>
  /// <para>
  /// For more information, see:
  /// <see href="https://learn.microsoft.com/en-us/dotnet/api/documentformat.openxml.customproperties.customdocumentproperty.formatid"/>
  /// </para>
  /// </remarks>
  [OpenXmlProperty(nameof(DXCP.CustomDocumentProperty.FormatId))]
  public Guid? FormatId { get => _FormatId; set => UpdateField(ref _FormatId, value, nameof(FormatId)); }
  private Guid? _FormatId = new Guid("D5CDD505-2E9C-101B-9397-08002B2CF9AE");

  /// <summary>
  /// Link target for the custom document property in OpenXml.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The <b>LinkTarget</b> property specifies the target of a link if the custom property is a linked property.
  /// This is typically a reference to an external file, object, or location that the property is associated with.
  /// </para>
  /// <para>
  /// If the custom property is not a link, this property is usually <c>null</c> or empty.
  /// </para>
  /// <para>
  /// For more information, see:
  /// <see href="https://learn.microsoft.com/en-us/dotnet/api/documentformat.openxml.customproperties.customdocumentproperty.linktarget"/>
  /// </para>
  /// </remarks>
  [OpenXmlProperty(nameof(DXCP.CustomDocumentProperty.LinkTarget))]
  public string? LinkTarget { get => _LinkTarget; set => UpdateField(ref _LinkTarget, value, nameof(LinkTarget)); }
  private string? _LinkTarget;

  /// <summary>
  ///   Value of the property
  /// </summary>
  public override object? Value
  {
    get
    {
      if (_OpenXmlCustomProperty == null)
        return base.Value;
      return GetAttachedPropertyInfo();
    }
    set
    {
      base.Value = value;
      base.Type = value?.GetType();
      if (_OpenXmlCustomProperty != null)
        SetAttachedPropertyValue(value);
    }
  }

  /// <summary>
  /// Sets the value of the built-in property using the provided string value.
  /// The method converts the string value to the appropriate type based on the PropertyInfo and sets it on the BaseObject.
  /// If the conversion or setting of the value fails, an InvalidOperationException is thrown with details about the failure.
  /// </summary>
  /// <param name="value">The string value to set for the built-in property.</param>
  /// <exception cref="InvalidOperationException">Thrown when the conversion or setting of the value fails.</exception>
  internal void SetAttachedPropertyValue(object? value)
  {
    if (_OpenXmlCustomProperty != null)
    {
      try
      {
        var valElement = VariantConverter.CreateOpenXmlElement(value);
        var openXmlElement = _OpenXmlCustomProperty.FirstChild;
        if (openXmlElement != null)
          openXmlElement.Remove();
        _OpenXmlCustomProperty.Append(valElement);
      }
      catch (Exception e)
      {
        throw new InvalidOperationException(
          $"Failed to set the value of the custom property '{Name}'.", e);
      }
    }
  }

  /// <summary>
  /// Gets the value of the built-in property as a string by retrieving the value from the BaseObject using the PropertyInfo and converting it to a string representation.
  /// </summary>
  /// <returns>The string representation of the built-in property's value.</returns>
  /// <exception cref="InvalidOperationException">Thrown when the conversion or retrieval of the value fails.</exception>
  internal object? GetAttachedPropertyInfo()
  {
    if (_OpenXmlCustomProperty != null)
    {
      try
      {
        var openXmlElement = (_OpenXmlCustomProperty)?.FirstChild;
        if (openXmlElement != null)
        {
          var vtVariant = VariantConverter.CreateVariant(openXmlElement);
          var value = vtVariant.Value;
          base.Type = value?.GetType();
          return value;
        }
        return null;
      }
      catch (Exception e)
      {
        throw new InvalidOperationException($"Failed to get the value of the custom property '{Name}'.",
          e);
      }
    }
    return null;
  }



  /// <summary>
  /// Value of the custom document property.
  /// </summary>
  [OpenXmlUpdateData(nameof(UpdateValueInOpenXml))]
  [OpenXmlLoadData(nameof(LoadValueFromOpenXml))]
  [XmlIgnore]
  [JsonIgnore]
  public Variant? VariantValue
  {
    get
    {
      var value = new Variant(base.Value);
      var openXmlElement = (GetUpdatableElement() as DXCP.CustomDocumentProperty)?.FirstChild;
      if (openXmlElement != null)
      {
        var vtVariant = openXmlElement.AsVTVariant();
        if (vtVariant != null)
          value = VariantConverter.CreateVariant(vtVariant!);
      }
      return value;
    }

    set
    {
      var _Value = new Variant(base.Value);
      if (value != _Value)
      {
        base.Value = value;
        base.Type = value?.GetType();
        if (GetUpdatableElement() is DXCP.CustomDocumentProperty openXmlElement)
        {
          openXmlElement.RemoveAllChildren();
          if (value != null)
            openXmlElement.AppendChild(value.AsVTVariant());
        }

        NotifyPropertyChanged(nameof(Value));
      }
    }
  }

  /// <summary>
  /// Needed to set the value in OpenXml element.
  /// </summary>
  /// <param name = "openXmlElement">OpenXml element to set the value in.</param>
  public void UpdateValueInOpenXml(DX.OpenXmlElement openXmlElement)
  {
    openXmlElement.RemoveAllChildren();
    if (Value != null)
      openXmlElement.AppendChild(Value.AsVTVariant());
  }

  /// <summary>
  /// Needed to get the value in OpenXml element.
  /// </summary>
  /// <param name = "openXmlElement">OpenXml element to set the value in.</param>
  public void LoadValueFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    var firstChild = openXmlElement.FirstChild;
    if (firstChild != null)
    {
      var value = VariantConverter.GetValue(firstChild);
      base.Value = value;
      base.Type = value?.GetType();
    }
  }
}