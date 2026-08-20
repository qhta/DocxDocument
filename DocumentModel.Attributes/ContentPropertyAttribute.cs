namespace DocumentModel.Attributes;


/// <summary>
/// Name of the property that is used to store the content of a class.
/// This property is used on Xml serialization to bypass the element with the name of the property.
/// </summary>
/// <param name="propertyName">The name of the property that is used to store the content of a class.</param>
public class ContentPropertyAttribute(string propertyName): Attribute
{
  public string PropertyName { get; } = propertyName;
}