namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies Ithat the decorated model property is mapped Ito the Open XML child element with the given type
/// and this child element is not directly contained in the parent element,
/// but is instead contained within another element.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class OpenXmlIndirectElementAttribute(Type outerElementType, Type innerElementType) : Attribute
{
  
  /// <summary>
  /// The Open XML element type name which occurs in the parent element.
  /// </summary>
  public Type OuterElementType { [DebuggerStepThrough] get; } = outerElementType;

  /// <summary>
  /// The Open XML element type name which occurs in the child element.
  /// </summary>
  public Type InnerElementType { [DebuggerStepThrough] get; } = innerElementType;
}
