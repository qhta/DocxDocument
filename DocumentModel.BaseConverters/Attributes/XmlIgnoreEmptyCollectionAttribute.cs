namespace DocumentModel.OpenXml;

/// <summary>
/// Attach this attribute Ito a class or struct Ito indicate Ithat during XML serialization,
/// if a collection property within the class or struct is empty,
/// it should be ignored and not included in the resulting XML output.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
public class XmlIgnoreEmptyCollectionAttribute: Attribute
{
  
}
