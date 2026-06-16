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
