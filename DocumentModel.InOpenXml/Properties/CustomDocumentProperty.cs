namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
public class CustomDocumentProperty : DocumentProperty
{

  /// <summary>
  /// The underlying Open XML custom document property associated with this instance.
  /// </summary>
  internal CP.CustomDocumentProperty? OpenXmlCustomDocumentProperty { get; private set; }


  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  public CustomDocumentProperty(): base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="CustomDocumentPropertyClass"/> class.
  /// </summary>
  /// <param name="propertiesCollection">Collection that contains this property</param>
  /// <param name="openXmlCustomDocumentProperty">Element from the Open XML SDK representing a custom document property.</param>
  public CustomDocumentProperty(CustomProperties propertiesCollection,
    CP.CustomDocumentProperty openXmlCustomDocumentProperty) //: base(propertiesCollection)
  {
    OpenXmlCustomDocumentProperty = openXmlCustomDocumentProperty;
  }

  public CP.CustomDocumentProperty CreateOpenCustomDocumentProperty()
  {
    OpenXmlCustomDocumentProperty ??= new CP.CustomDocumentProperty();
    SetValuesToOpenXmlProperty(OpenXmlCustomDocumentProperty);
    return OpenXmlCustomDocumentProperty!;
  }

  /// <summary>
  /// Gets values from OpenXml CustomDocumentProperty to this instance.
  /// </summary>
  private void GetValuesFromOpenXmlProperty(CP.CustomDocumentProperty openXmlCustomDocumentProperty)
  {
    foreach (var propertyInfo in typeof(CustomDocumentProperty).GetProperties())
    {
      var value = propertyInfo.GetValue(openXmlCustomDocumentProperty);
      propertyInfo.SetValue(this, value);
    }
  }

  /// <summary>
  /// Sets values from this instance to OpenXml CustomDocumentProperty.
  /// </summary>
  private void SetValuesToOpenXmlProperty(CP.CustomDocumentProperty openXmlCustomDocumentProperty)
  {
    foreach (var propertyInfo in typeof(CustomDocumentProperty).GetProperties())
    {
      var value = propertyInfo.GetValue(this);
      propertyInfo.SetValue(openXmlCustomDocumentProperty, value);
    }
  }

  /// <summary>
  ///   Property identifier. Should be unique within the document properties.
  ///   In OpenXml property identifiers start from 2.
  /// </summary>
  [XmlAttribute]
  public int? PropertyId
  {
    get
    {
      var value = OpenXmlCustomDocumentProperty?.PropertyId?.Value ?? _PropertyId;
      return value;
    }
    set
    {
      if (value != _PropertyId)
      {
        _PropertyId = value;
        if (OpenXmlCustomDocumentProperty != null)
          OpenXmlCustomDocumentProperty.PropertyId = value != null ? new OpenXml.Int32Value(value) : null;
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
      return value;
    }
    set
    {
      if (value != _Name)
      {
        _Name = value;
        if (OpenXmlCustomDocumentProperty != null)
          OpenXmlCustomDocumentProperty.Name = value != null ? new OpenXml.StringValue(value) : null;
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
  [XmlAttribute]
  public Guid? FormatId
  {
    get
    {
      Guid? value = _FormatId;
      if (OpenXmlCustomDocumentProperty?.FormatId?.Value != null)
        if (Guid.TryParse(OpenXmlCustomDocumentProperty.FormatId.Value, out var guidValue))
          value = guidValue;
      return value;
    }
    set
    {
      if (value != _FormatId)
      {
        _FormatId = value;
        if (OpenXmlCustomDocumentProperty != null)
          OpenXmlCustomDocumentProperty.FormatId = value != null ? new OpenXml.StringValue(value.ToString()) : null;
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
      return value;
    }
    set
    {
      if (value != _LinkTarget)
      {
        _LinkTarget = value;
        if (OpenXmlCustomDocumentProperty != null)
          OpenXmlCustomDocumentProperty.LinkTarget = value != null ? new OpenXml.StringValue(value) : null;
        NotifyPropertyChanged(nameof(LinkTarget));
      }
    }
  }
  private string? _LinkTarget;

}