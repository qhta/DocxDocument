namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies mapping of the model enum type to one of the types used in Microsoft.Office.Core.
/// </summary>
/// <param name="targetType">The type to be associated with the decorated Enum type when converted to/from Microsoft.Office.Core.</param>
[AttributeUsage(AttributeTargets.Enum, Inherited = true, AllowMultiple = true)]
public class CoreInteropEnumTypeAttribute(Type targetType) : Attribute
{

  /// <summary>
  /// The Microsoft.Office.Interop.Word type associated with the decorated enum.
  /// </summary>
  public Type TargetType { [DebuggerStepThrough] get; } = targetType;

}
