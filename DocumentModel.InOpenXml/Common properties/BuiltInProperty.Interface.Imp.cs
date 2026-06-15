namespace DocumentModel;

public partial class BuiltInProperty : DMPr.IDocumentProperty
{
  /// <summary>
  /// Name of the custom document property. If not set, it defaults to an empty string.
  /// </summary>
  string DMPr.IDocumentProperty.Name { get => this.Name ?? string.Empty; set => this.Name = value; }

  /// <summary>
  /// Value of the document property, which can be of any type. The actual type of the value is determined by the Type property.
  /// </summary>
  object? DMPr.IDocumentProperty.Value
  {
    get => Value;
    set => Value = value;
  }

  /// <summary>
  /// Expected value type. According to the documentation, this property can be of any type.
  /// However, in practice, it is typically an enumeration that indicates the type of the value assigned to the Value property.
  /// The possible values for this property are defined in the DocPropertyType enumeration, which includes types such as String, Number, Date, and Boolean.
  /// For built-in document properties, this property is read-only and returns the type of the property.
  /// For custom document properties, this property is read/write and determines the type of the value that can be assigned to the Value property.
  /// </summary>
  DMPr.DocumentPropertyType DMPr.IDocumentProperty.Type
  {
    get => this.ExpectedType; set => this.ExpectedType = value;
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
  }
}
