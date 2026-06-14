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
  ///   Expected value type
  /// </summary>
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
  public virtual DMPr.DocPropertyType ExpectedType
  {
    [DebuggerStepThrough] get => _ExpectedType;
    [DebuggerStepThrough] set => UpdateField(ref _ExpectedType, value, nameof(ExpectedType));
  }
  private DMPr.DocPropertyType _ExpectedType;

  /// <summary>
  /// Expected value type as a System.Type. This property is not serialized and is used internally to determine the type of the value for conversion purposes.
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