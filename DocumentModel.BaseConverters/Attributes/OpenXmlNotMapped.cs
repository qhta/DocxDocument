namespace DocumentModel.OpenXml;

/// <summary>
/// Determines that decorated type is not mapped to OpenXml type.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
public class OpenXmlNotMappedAttribute: Attribute
{
  
}