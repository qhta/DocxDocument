namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies that the decorated model property type is mapped to the Open XML child element collection.
/// </summary>
[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public class OpenXmlElementCollectionAttribute() : Attribute
{

}