namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Document Property.
/// </summary>
[XmlContentProperty(nameof(Value))]
public partial class DocumentProperty : ModelElement
{
  /// <summary>
  ///   Default constructor. Needed for XML serialization.
  /// </summary>
  public DocumentProperty() { }

  /// <summary>
  /// Full initializing constructor.
  /// </summary>
  /// <param name="category">Category of the document property.</param>
  /// <param name="name">Name of the document property.</param>
  /// <param name="type">Type of the document property.</param>
  /// <param name="value">Value of the document property.</param>
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

  /// <summary>
  /// Initializing constructor without category.
  /// </summary>
  /// <param name="name"></param>
  /// <param name="type"></param>
  /// <param name="value"></param>
  public DocumentProperty(string name, Type? type = null, object? value = null)
  {
    Category = null;
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

  /// <summary>
  /// Copying constructor.
  /// </summary>
  /// <param name="other"></param>
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

  /// <summary>
  /// Returns a string that represents the current document property, including its name and value.
  /// </summary>
  /// <returns>A string representation of the document property. If the value is a collection of strings, the value is displayed
  /// as a comma-separated list; otherwise, the value is displayed as a single item.</returns>
  public override string ToString()
  {
    if (Value is IEnumerable<string> strings)
      return $"DocumentProperty({Name} = ({string.Join(",", strings)}))";

    return $"DocumentProperty({Name} = {Value})";
  }

}