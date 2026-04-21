namespace DocumentModel.OpenXml;

/// <summary>
/// Indicates a property or collection that is lazily loaded from the underlying OpenXml element. When applied, the property will not be initialized until it is first accessed, allowing for deferred loading of data and improved performance when working with large documents or complex structures.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class LazyLoadAttribute: Attribute
{
  
}