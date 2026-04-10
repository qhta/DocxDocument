namespace DocumentModel;
/// <summary>
/// Contains constants for property categories, providing a standardized way to categorize properties across different types.
///
/// </summary>
[XmlRoot("PropertyCategories", Namespace = "DocumentModel")]
public static class PropertyCategories
{
 /// <summary>
 /// Base properties category containing fundamental properties such as Title, Subject, Creator, and Keywords.
 /// </summary>
 public static string Base = "Base";
}