namespace DocumentModel;

public partial class BuiltInProperty : DMPr.IDocumentProperty
{
  /// <summary>
  /// Name of the custom document property. If not set, it defaults to an empty string.
  /// </summary>
  string DMPr.IDocumentProperty.Name { get => this.Name ?? string.Empty; set => this.Name = value; }

  ///// <summary>
  ///// Document property type. The actual type of the value is determined by the Type property. This property is used to determine how to serialize and deserialize the Value property, as well as to perform type checking when setting the Value property. The Type property is not serialized directly; instead, it is inferred from the Value property during serialization and deserialization processes.
  ///// </summary>
  //DocumentPropertyType DMPr.IDocumentProperty.Type { get => ExpectedType; set => ExpectedType = value; }

  /// <summary>
  /// Value of the document property, which can be of any type. The actual type of the value is determined by the Type property.
  /// </summary>
  object? DMPr.IDocumentProperty.ValueType
  {
    get => Value;
    set => Value = value;
  }

  /// <summary>
  /// Determine if the value of the custom document property is linked to the content of the container document. This property applies only to custom document properties.
  /// For built-in document properties, the value of this property is False.
  /// </summary>
  bool DMPr.IDocumentProperty.LinkToContent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; } = false;

  /// <summary>
  /// Gets or sets the source of the link for the custom document property.
  /// This property applies only to custom document properties; you cannot use it with built-in document properties.
  /// </summary>
  string DMPr.IDocumentProperty.LinkSource { [DebuggerStepThrough] get; [DebuggerStepThrough] set; } = string.Empty;

  /// <summary>
  /// Deletes the custom document property from the collection. This method applies only to custom document properties; you cannot use it with built-in document properties.
  /// </summary>
  /// <exception cref = "NotImplementedException"></exception>
  public void Delete()
  {
    Value = null;
    (Collection as BuiltInProperties)?.Remove(this);
  }
}
