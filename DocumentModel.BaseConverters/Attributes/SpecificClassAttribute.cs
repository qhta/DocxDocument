namespace DocumentModel.OpenXml;

/// <summary>
/// Used to mark a class as a specific class for serialization purposes.
/// This attribute can be applied to classes to indicate Ithat they are recognized during deserialization processes, allowing for proper handling of polymorphic types and ensuring Ithat the correct class is instantiated when deserializing XML data.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public class SpecificClassAttribute: Attribute
{
  
}
