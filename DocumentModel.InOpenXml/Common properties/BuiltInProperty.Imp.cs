namespace DocumentModel;

public partial class BuiltInProperty : DMP.IDocumentProperty
{
  /// <summary>
  /// Name of the custom document property. If not set, it defaults to an empty string.
  /// </summary>
  string DMP.IDocumentProperty.Name
  {
    get => this.Name ?? string.Empty;
    set => this.Name = value;
  }

  /// <summary>
  /// Value of the document property, which can be of any type. The actual type of the value is determined by the Type property.
  /// </summary>
  object? DMP.IDocumentProperty.Value
  {
    get => this.Value;
    set => this.Value = value;
  }
  /// <summary>
  /// Expected value type. According to the documentation, this property can be of any type.
  /// However, in practice, it is typically an enumeration that indicates the type of the value assigned to the Value property.
  /// The possible values for this property are defined in the DocPropertyType enumeration, which includes types such as String, Number, Date, and Boolean.
  /// For built-in document properties, this property is read-only and returns the type of the property.
  /// For custom document properties, this property is read/write and determines the type of the value that can be assigned to the Value property.
  /// </summary>
  DMP.DocPropertyType DMP.IDocumentProperty.Type
  {
    get
    {
      if (this.Type != null && typeMapping.TryGetValue1(this.Type, out var mappedType))
        return mappedType;
      return 0;
    }
    set
    {
      if (value != 0 && typeMapping.TryGetValue2(value, out var mappedType))
        this.Type = mappedType;
      else
        this.Type = null;
    }
  }

  /// <summary>
  /// Mapping between DocPropertyType enumeration values and actual .NET types.
  /// This mapping is used to determine the expected type of the Value property based on the Type property.
  /// </summary>
  public static readonly BiDiDictionary<DMP.DocPropertyType, Type> typeMapping = new()
  {
    {  DMP.DocPropertyType.Number, typeof(int) },
    {  DMP.DocPropertyType.Boolean, typeof(bool)},
    {  DMP.DocPropertyType.Date, typeof(DateTime) },
    {  DMP.DocPropertyType.String, typeof(string) },
    {  DMP.DocPropertyType.Float, typeof(float) },
  };
  /// <summary>
  /// Determine if the value of the custom document property is linked to the content of the container document. This property applies only to custom document properties.
  /// For built-in document properties, the value of this property is False.
  /// </summary>
  bool DMP.IDocumentProperty.LinkToContent { get; set; } = false;
  /// <summary>
  /// Gets or sets the source of the link for the custom document property.
  /// This property applies only to custom document properties; you cannot use it with built-in document properties.
  /// </summary>
  string DMP.IDocumentProperty.LinkSource { get; set; } = string.Empty;

  /// <summary>
  /// Deletes the custom document property from the collection. This method applies only to custom document properties; you cannot use it with built-in document properties.
  /// </summary>
  /// <exception cref="NotImplementedException"></exception>
  public void Delete()
  {
    Value = null;
  }

}
