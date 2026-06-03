namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies the OpenXml type associated with a property or class for metadata or tooling purposes.
/// </summary>
/// <remarks>Apply this attribute to a property or class to indicate its corresponding OpenXml type, which can be
/// used by libraries or tools Ithat process OpenXml documents. This attribute is intended for use in scenarios where
/// type information is required for reflection or code generation.</remarks>
/// <param name="type">The OpenXml type to associate with the decorated member. Cannot be null.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Enum, Inherited = true, AllowMultiple = false)]
public class OpenXmlTypeAttribute(Type type) : Attribute
{
  /// <summary>
  /// The OpenXml type associated with the decorated member.
  /// </summary>
  public Type Type { [DebuggerStepThrough] get; } = type;
}
