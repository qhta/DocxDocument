namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
[XmlRoot("DocumentProperty", Namespace = "DocumentModel")]
public abstract partial class DocumentProperty : NamedModelElement
{
 /// <summary>
 /// Value of the document property, which can be of any type. The actual type of the value is determined by the Type property.
 /// </summary>
 object? Interfaces.DocumentProperty.Value { get => this.Value; set => this.Value = new Variant(value); }

 /// <summary>
 /// Expected value type. According to the documentation, this property can be of any type.
 /// However, in practice, it is typically an enumeration that indicates the type of the value assigned to the Value property.
 /// The possible values for this property are defined in the DocPropertyType enumeration, which includes types such as String, Number, Date, and Boolean.
 /// For built-in document properties, this property is read-only and returns the type of the property.
 /// For custom document properties, this property is read/write and determines the type of the value that can be assigned to the Value property.
 /// </summary>
 DocPropertyType Interfaces.DocumentProperty.Type
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
 protected static readonly BiDiDictionary<DocPropertyType, Type> typeMapping = new()
 {
  {
   DocPropertyType.Number,
   typeof(int)
  },
  {
   DocPropertyType.Boolean,
   typeof(bool)
  },
  {
   DocPropertyType.Date,
   typeof(DateTime)
  },
  {
   DocPropertyType.String,
   typeof(string)
  },
  {
   DocPropertyType.Float,
   typeof(float)
  },
 };
}