namespace DocumentModel;

/// <summary>
///   Abstract document Property.
/// </summary>
[DataContract]
[XmlRoot("DocumentProperty", Namespace = "DocumentModel")]
//[JsonConverter(typeof(DocumentPropertyJsonConverter<DocumentProperty>))]
public abstract partial class DocumentProperty : ModelElement, INamedObject
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  protected DocumentProperty()
  {
  }

  /// <summary>
  /// Represents the name of the model element.
  /// Setting this property will raise the NameChanged event if the name changes.
  /// </summary>
  public string? Name
  {
    get => _name;
    set => UpdateField(ref _name, value, nameof(Name));
  }
  /// <summary>
  /// Backing field for the Name property. It must be protected to allow BuiltInProperty to set it directly during XML deserialization without triggering the PropertyChanged event, which could lead to unintended side effects during deserialization.
  /// </summary>
  protected string? _name;

  /// <summary>
  ///   Property identifier. Should be unique within the document properties.
  ///   In OpenXml property identifiers start from 2.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public virtual int? PropertyId { get => _propertyId; set => UpdateField(ref _propertyId, value, nameof(PropertyId)); }
  /// <summary>
  /// Backing field for the PropertyId property. It must be protected to allow BuiltInProperty to set it directly during XML deserialization without triggering the PropertyChanged event, which could lead to unintended side effects during deserialization.
  /// </summary>
  protected int? _propertyId;

  /// <summary>
  ///  Value of the property, which can be of any type. The actual type of the value is determined by the Type property.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public virtual Object? Value
  {
    [DebuggerStepThrough]
    get => _value;
    [DebuggerStepThrough]
    set => UpdateField(ref _value, value, nameof(Value));
  }
  /// <summary>
  /// Backing field for the Value property. It must be protected to allow BuiltInProperty to set it directly during XML deserialization without triggering the PropertyChanged event, which could lead to unintended side effects during deserialization.
  /// </summary>
  protected object? _value;

  /// <summary>
  /// Expected value type. Only five types of values are supported: String, Boolean, Integer, Float and DateTime.
  /// This property is declared to provide conformance to Word's custom document properties,
  /// which only support these five types of values.
  /// </summary>

  public virtual DMPr.DocumentPropertyType ExpectedType
  {
    [DebuggerStepThrough]
    get => _expectedType ?? Value?.GetType()?.ConvertToDocumentPropertyType() ?? DMPr.DocumentPropertyType.Unknown;
    [DebuggerStepThrough]
    set => UpdateField(ref _expectedType, value, nameof(ExpectedType));
  }
  /// <summary>
  /// Backing field for the ExpectedType property. It must be protected to allow BuiltInProperty to set it directly during XML deserialization without triggering the PropertyChanged event, which could lead to unintended side effects during deserialization.
  /// </summary>
  protected DMPr.DocumentPropertyType? _expectedType;

  /// <summary>
  /// Value type. It is determined by the actual type of the Value property. This property is used to determine how to serialize and deserialize the Value property, as well as to perform type checking when setting the Value property. The Type property is not serialized directly; instead, it is inferred from the Value property during serialization and deserialization processes.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public virtual Type? ValueType
  {
    [DebuggerStepThrough]
    get => _valueType ?? Value?.GetType();
    [DebuggerStepThrough]
    set => UpdateField(ref _valueType, value, nameof(ValueType));
  }
  /// <summary>
  /// Backing field for the ValueType property. It must be protected to allow BuiltInProperty to set it directly during XML deserialization without triggering the PropertyChanged event, which could lead to unintended side effects during deserialization.
  /// </summary>
  protected Type? _valueType;

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
  [XmlIgnore]
  [JsonIgnore]
  public virtual string? LinkTarget { get => _linkTarget; set => UpdateField(ref _linkTarget, value, nameof(LinkTarget)); }
  /// <summary>
  /// Backing field for the LinkTarget property. It must be protected to allow CustomProperty to set it directly during XML deserialization without triggering the PropertyChanged event, which could lead to unintended side effects during deserialization.
  /// </summary>
  protected string? _linkTarget;
}