using Microsoft.Office.Interop.Word;

namespace DocumentModel;

//[XmlArrayItem("BuiltInProperty", typeof(BuiltInProperty))]
/// <summary>
///   Abstract document Property.
/// </summary>
[XmlRoot("DocumentProperty", Namespace = "DocumentModel")]
public abstract partial class DocumentProperty : NamedModelElement
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  protected DocumentProperty()
  {
  }


  /// <summary>
  ///  Value of the property, which can be of any type. The actual type of the value is determined by the Type property.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public virtual Object? Value
  {
    [DebuggerStepThrough] get => _value; 
    [DebuggerStepThrough] set => UpdateField(ref _value, value, nameof(Value));
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
  [XmlIgnore]
  [JsonIgnore]
  public virtual DMPr.DocumentPropertyType ExpectedType
  {
    [DebuggerStepThrough]
    get => _ExpectedType ??Type?.ConvertToDocumentPropertyType() ?? DocumentPropertyType.Unknown;
    [DebuggerStepThrough]
    set
    {
      UpdateField(ref _ExpectedType, value, nameof(ExpectedType)); 
      Type = value.ConvertToSystemType();
    }
  }
  private DMPr.DocumentPropertyType? _ExpectedType;

  /// <summary>
  /// Value type. It is determined by the actual type of the Value property. This property is used to determine how to serialize and deserialize the Value property, as well as to perform type checking when setting the Value property. The Type property is not serialized directly; instead, it is inferred from the Value property during serialization and deserialization processes.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public virtual Type? Type
  {
    [DebuggerStepThrough] get => _type;
    [DebuggerStepThrough] set => UpdateField(ref _type, value, nameof(Type));
  }
  /// <summary>
  /// Backing field for the Type property. It must be protected to allow BuiltInProperty to set it directly during XML deserialization without triggering the PropertyChanged event, which could lead to unintended side effects during deserialization.
  /// </summary>
  protected Type? _type;
}