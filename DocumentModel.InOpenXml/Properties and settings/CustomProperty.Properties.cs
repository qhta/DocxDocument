namespace DocumentModel;

public sealed partial class CustomProperty
{
  /// <summary>
  ///   Property identifier. Should be unique within the document properties.
  ///   In OpenXml property identifiers start from 2.
  /// </summary>
  [OpenXmlProperty(nameof(DXCP.CustomDocumentProperty.PropertyId))]
  public int? PropertyId
  {
    get => _PropertyId;
    set => UpdateField(ref _PropertyId, value, nameof(PropertyId));
  }

  private int? _PropertyId;

  /// <summary>
  ///   Property name. Should be unique within the document properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXCP.CustomDocumentProperty.Name))]
  public string? Name
  {
    get => _Name;
    set => UpdateField(ref _Name, value, nameof(Name));
  }

  private string? _Name;

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
  public Guid? FormatId
  {
    get => _FormatId;
    set => UpdateField(ref _FormatId, value, nameof(FormatId));
  }
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
  public string? LinkTarget
  {
    get => _LinkTarget;
    set => UpdateField(ref _LinkTarget, value, nameof(LinkTarget));
  }
  private string? _LinkTarget;

  /// <summary>
  /// Value of the custom document property.
  /// </summary>
  [OpenXmlUpdateData(nameof(UpdateValueInOpenXml))]
  [OpenXmlLoadData(nameof(LoadValueFromOpenXml))]
  public Variant? Value
  {
    get
    {
      var value = _Value;
      var openXmlElement = GetOpenXmlElement()?.FirstChild;
      if (openXmlElement != null)
      {
        _Value = value;
      }
      return value;
    }
    set
    {
      if (value != _Value)
      {
        _Value = value;
        var openXmlElement = GetOpenXmlElement();
        if (openXmlElement != null)
        {
          openXmlElement.RemoveAllChildren();
          if (value != null)
            openXmlElement.AppendChild(value.AsVTVariant());
        }
        NotifyPropertyChanged(nameof(Value));
      }
    }
  }

  private Variant? _Value;

  /// <summary>
  /// Needed to set the value in OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">OpenXml element to set the value in.</param>
  public void UpdateValueInOpenXml(DX.OpenXmlElement openXmlElement)
  {
    openXmlElement.RemoveAllChildren();
    openXmlElement.AppendChild(Value.AsVTVariant());
  }

  /// <summary>
  /// Needed to get the value in OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">OpenXml element to set the value in.</param>
  public void LoadValueFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    var firstChild = openXmlElement.FirstChild;
    if (firstChild != null)
    {
      var variant = VariantConverter.GetVariant(firstChild);
      _Value = variant;
    }
  }

  ///// <summary>
  ///// Needed to get the value from OpenXml element.
  ///// </summary>
  ///// <param name="openXmlElement">OpenXml element to get the value from.</param>
  //public Variant? GetValueInOpenXml(DX.OpenXmlElement openXmlElement)
  //{
  //  var firstChild = openXmlElement.FirstChild;
  //  if (firstChild == null)
  //    return null;
  //  var variant = VariantConverter.GetVariant(firstChild);
  //  _Value = variant;
  //  return variant;
  //}

  /// <summary>
  /// Type of the custom document property.
  /// </summary>
  [NotMapped]
  public string? Type
  {
    get
    {
      var type = _Type;
      if (type == null && _Value != null)
      {
        type = _Value.ValueType;
        _Type = type;
      }
      return type?.Name;
    }
    set
    {
      if (value != _Type?.Name)
      {
        var type = _Type;
        if (value != null)
          type = TypeHelper.GetType(value);
        if (type != null && _Value != null && _Value.ValueType != type)
        {
          // Try to convert the value to the specified type
          //try
          {
            var convertedValue = _Value.ConvertTo(type);
            _Value = convertedValue;
            var openXmlElement = GetOpenXmlElement();
            if (openXmlElement != null)
            {
              openXmlElement.RemoveAllChildren();
              openXmlElement.AppendChild(convertedValue.AsVTVariant());
            }
          }
          //catch (Exception)
          //{
          //  //Console.WriteLine($"Error converting value of type {_Value?.GetType().FontName} to type: " + type?.FontName);
          //}
        }
        NotifyPropertyChanged(nameof(Value));
      }
    }
  }

  private Type? _Type;
}