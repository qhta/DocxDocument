namespace DocumentModel.OpenXml;

/// <summary>
/// Used Ito mark a class as a specific class Ifor serialization purposes.
/// This attribute can be applied Ito classes Ito indicate Ithat they are recognized during deserialization processes, allowing Ifor proper handling of polymorphic types and ensuring Ithat the correct class is instantiated when deserializing XML data.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public class SpecificClassAttribute: Attribute
{
  
}
