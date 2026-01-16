using DocumentFormat.OpenXml;

namespace DocumentModel;
/// <summary>
///   Custom-defined document property.
/// </summary>
public class CustomProperty : DocumentProperty
{

  /// <summary>
  /// The underlying Open XML custom document property associated with this instance.
  /// </summary>
  internal DXCP.CustomDocumentProperty? OpenXmlCustomDocumentProperty { get; private set; }

  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  public CustomProperty() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="CustomDocumentPropertyClass"/> class.
  /// </summary>
  /// <param name="propertiesCollection">Collection that contains this property</param>
  /// <param name="openXmlCustomDocumentProperty">Element from the Open XML SDK representing a custom document property.</param>
  public CustomProperty(CustomProperties propertiesCollection,
    DXCP.CustomDocumentProperty openXmlCustomDocumentProperty) //: base(propertiesCollection)
  {
    OpenXmlCustomDocumentProperty = openXmlCustomDocumentProperty;
  }

  /// <summary>
  /// Creates and initializes an open custom document property based on the current state of the object.
  /// </summary>
  /// <remarks>If the custom document property has already been created, this method returns the existing
  /// instance. Otherwise, it creates a new property and initializes it with the current values.</remarks>
  /// <returns>A <see cref="DXCP.CustomDocumentProperty"/> instance representing the open custom document property with values set
  /// from the current object.</returns>
  public DXCP.CustomDocumentProperty CreateOpenCustomDocumentProperty()
  {
    OpenXmlCustomDocumentProperty ??= new DXCP.CustomDocumentProperty();
    SetValuesToOpenXmlProperty(OpenXmlCustomDocumentProperty);
    return OpenXmlCustomDocumentProperty!;
  }

  /// <summary>
  /// Gets values from OpenXml CustomDocumentProperty to this instance.
  /// </summary>
  private void GetValuesFromOpenXmlProperty(DXCP.CustomDocumentProperty openXmlCustomDocumentProperty)
  {
    foreach (var propertyInfo in typeof(CustomProperty).GetProperties())
    {
      var value = propertyInfo.GetValue(openXmlCustomDocumentProperty);
      propertyInfo.SetValue(this, value);
    }
  }

  /// <summary>
  /// Sets values from this instance to OpenXml CustomDocumentProperty.
  /// </summary>
  private void SetValuesToOpenXmlProperty(DXCP.CustomDocumentProperty openXmlCustomDocumentProperty)
  {
    foreach (var propertyInfo in typeof(CustomProperty).GetProperties())
    {
      base.UpdateData(propertyInfo, openXmlCustomDocumentProperty, typeof(DXCP.CustomDocumentProperty));
    }
  }

  /// <summary>
  ///   Property identifier. Should be unique within the document properties.
  ///   In OpenXml property identifiers start from 2.
  /// </summary>
  public int? PropertyId
  {
    get
    {
      var value = OpenXmlCustomDocumentProperty?.PropertyId?.Value ?? _PropertyId;
      _PropertyId = value;
      return value;
    }
    set
    {
      if (value != _PropertyId)
      {
        _PropertyId = value;
        if (OpenXmlCustomDocumentProperty != null)
          OpenXmlCustomDocumentProperty.PropertyId = value != null ? new DX.Int32Value(value) : null;
        NotifyPropertyChanged(nameof(PropertyId));
      }
    }
  }
  private int? _PropertyId;


  /// <summary>
  ///   Property name. Should be unique within the document properties.
  /// </summary>
  [XmlAttribute]
  public override string? Name
  {
    get
    {
      var value = OpenXmlCustomDocumentProperty?.Name?.Value ?? _Name;
      _Name = value;
      return value;
    }
    set
    {
      if (value != _Name)
      {
        _Name = value;
        if (OpenXmlCustomDocumentProperty != null)
          OpenXmlCustomDocumentProperty.Name = value != null ? new DX.StringValue(value) : null;
        NotifyPropertyChanged(nameof(Name));
      }
    }
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
  //[XmlAttribute]
  public Guid? FormatId
  {
    get
    {
      Guid? value = _FormatId;
      if (OpenXmlCustomDocumentProperty?.FormatId?.Value != null)
        if (Guid.TryParse(OpenXmlCustomDocumentProperty.FormatId.Value, out var guidValue))
        {
          value = guidValue;
          _FormatId = value;
        }
      return value;
    }
    set
    {
      if (value != _FormatId)
      {
        _FormatId = value;
        if (OpenXmlCustomDocumentProperty != null)
          OpenXmlCustomDocumentProperty.FormatId = value != null ? new DX.StringValue(value.ToString()) : null;
        NotifyPropertyChanged(nameof(FormatId));
      }
    }
  }
  private Guid? _FormatId;

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
  [XmlAttribute]
  public string? LinkTarget
  {
    get
    {
      var value = OpenXmlCustomDocumentProperty?.LinkTarget?.Value ?? _LinkTarget;
      _LinkTarget = value;
      return value;
    }
    set
    {
      if (value != _LinkTarget)
      {
        _LinkTarget = value;
        if (OpenXmlCustomDocumentProperty != null)
          OpenXmlCustomDocumentProperty.LinkTarget = value != null ? new DX.StringValue(value) : null;
        NotifyPropertyChanged(nameof(LinkTarget));
      }
    }
  }
  private string? _LinkTarget;

  /// <summary>
  /// Value of the custom document property.
  /// </summary>
  public override Variant? Value
  {
    get
    {
      var value = _Value;
      var openXmlElement = OpenXmlCustomDocumentProperty?.FirstChild;
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
        if (OpenXmlCustomDocumentProperty != null)
        {
          OpenXmlCustomDocumentProperty.RemoveAllChildren();
          if (value != null)
            OpenXmlCustomDocumentProperty.AppendChild(value.AsVTVariant());
        }
        NotifyPropertyChanged(nameof(Value));
      }
    }
  }
  private Variant? _Value;

  /// <summary>
  /// Needed to set the value in OpenXml element.
  /// </summary>
  /// <param name="value">The new variant value to set.</param>
  public void SetValue(Variant value)
  {
    _Value = value;
    if (OpenXmlCustomDocumentProperty != null)
    {
      OpenXmlCustomDocumentProperty.RemoveAllChildren();
      OpenXmlCustomDocumentProperty.AppendChild(value.AsVTVariant());
    }
  }

  /// <summary>
  /// Type of the custom document property.
  /// </summary>
  public override string? Type
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
          try
          {
            var convertedValue = _Value.ConvertTo(type);
            _Value = convertedValue;
            if (OpenXmlCustomDocumentProperty != null)
            {
              OpenXmlCustomDocumentProperty.RemoveAllChildren();
              OpenXmlCustomDocumentProperty.AppendChild(convertedValue.AsVTVariant());
            }
          }
          catch (Exception)
          {
            //Console.WriteLine($"Error converting value of type {_Value?.GetType().Name} to type: " + type?.Name);
          }
        }
        NotifyPropertyChanged(nameof(Value));
      }
    }
  }
  private Type? _Type;

  /// <summary>
  /// Needed to set the value type in OpenXml element.
  /// </summary>
  /// <param name="value">The new type name to set.</param>
  public void SetType(string? value)
  {
    Type = value;
  }


}