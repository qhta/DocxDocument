namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Document Property.
/// </summary>
[XmlContentProperty(nameof(Value))]
public partial class DocumentProperty : ModelElement
{
  public DocumentProperty() { }

  public DocumentProperty(string category, string name, Type? type = null, object? value = null)
  {
    Category = category;
    Name = name;
    if (type != null)
    {
      var typeName = type.Name;
      if (typeName.StartsWith("Nullable`"))
        type = type.GenericTypeArguments[0];
      Type = type;
    }
    Value = value;
  }

  public DocumentProperty(DocumentProperty other)
  {
    Category = other.Category;
    Name = other.Name;
    Value = other.Value;
  }

  /// <summary>
  ///   Property Category.
  /// </summary>
  public string? Category
  {
    get;
    set;
  }

  /// <summary>
  ///   Property Name.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }

  /// <summary>
  ///   Value of the property
  /// </summary>
  [TypeConverter(typeof(DocumentPropertyValueXmlConverter))]
  public object? Value
  {
    get => _value;
    set
    {
      if (Type == null && value != null)
        Type = value.GetType();
      _value = value;
    }
  }
  private object? _value;

  /// <summary>
  ///   Expected value type
  /// </summary>
  [TypeConverter(typeof(TypeNameConverter))]
   public Type? Type { get; set; }

  /// <summary>
  ///   Property ID
  /// </summary>
   public Int32? PropertyId { get; set; }

  /// <summary>
  ///   Bookmark Link Target
  /// </summary>
   public string? LinkTarget { get; set; }

  public override string ToString()
  {
    if (Value is IEnumerable<string> strings)
      return $"DocumentProperty({Name} = ({string.Join(",", strings)}))";

    return $"DocumentProperty({Name} = {Value})";
  }

}