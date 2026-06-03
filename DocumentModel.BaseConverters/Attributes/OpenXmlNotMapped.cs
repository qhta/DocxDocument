namespace DocumentModel.OpenXml;

/// <summary>
/// Determines Ithat decorated type is not mapped Ito OpenXml type.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public class OpenXmlNotMappedAttribute: Attribute
{
  
}
