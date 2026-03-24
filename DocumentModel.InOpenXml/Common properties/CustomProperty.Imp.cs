namespace DocumentModel;

public sealed partial class CustomProperty: DIC.DocumentProperty
{
  /// <summary>
  /// Name of the custom document property. If not set, it defaults to an empty string.
  /// </summary>
  string DIC.DocumentProperty.Name { get => this.Name ?? string.Empty; set => this.Name = value; } 

  /// <summary>
  /// Value of the document property, which can be of any type. The actual type of the value is determined by the Type property.
  /// </summary>
  object? DIC.DocumentProperty.Value
  {
    get => this.Value;
    set => this.Value = new Variant(value);
  }
  /// <summary>
  /// Expected value type. According to the documentation, this property can be of any type.
  /// However, in practice, it is typically an enumeration that indicates the type of the value assigned to the Value property.
  /// The possible values for this property are defined in the DocPropertyType enumeration, which includes types such as String, Number, Date, and Boolean.
  /// For built-in document properties, this property is read-only and returns the type of the property.
  /// For custom document properties, this property is read/write and determines the type of the value that can be assigned to the Value property.
  /// </summary>
   DIC.MsoDocProperties DIC.DocumentProperty.Type
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
  public static readonly BiDiDictionary<DIC.MsoDocProperties, string> typeMapping = new()
  {
		{  DIC.MsoDocProperties.Number, "Integer" },
		{  DIC.MsoDocProperties.Boolean, "Boolean"},
		{  DIC.MsoDocProperties.Date, "Date" },
		{  DIC.MsoDocProperties.String, "String" },
		{  DIC.MsoDocProperties.Float, "Float" },
  };
  /// <summary>
  /// Determine if the value of the custom document property is linked to the content of the container document. This property applies only to custom document properties.
  /// For built-in document properties, the value of this property is False.
  /// </summary>
  bool Interop.Core.DocumentProperty.LinkToContent { get; set; } = false;
  /// <summary>
  /// Gets or sets the source of the link for the custom document property.
  /// This property applies only to custom document properties; you cannot use it with built-in document properties.
  /// </summary>
  string Interop.Core.DocumentProperty.LinkSource { get; set; } = string.Empty;
}