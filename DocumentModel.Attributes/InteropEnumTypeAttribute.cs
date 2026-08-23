namespace DocumentModel;

/// <summary>
/// Specifies mapping of the model enum type to one of the types used in Microsoft.Office.Core
/// or Microsoft.Office.Interop.Word assembly
/// </summary>
[AttributeUsage(AttributeTargets.Enum, Inherited = true, AllowMultiple = true)]
public class InteropEnumTypeAttribute : Attribute
{
  /// <summary>
  /// Specifies mapping of the model enum type to one of the types used in interop assembly.
  /// </summary>
  /// <param name="targetType">The type to be associated with the decorated Enum type when converted to/from interop assembly.</param>
  public InteropEnumTypeAttribute(Type targetType)
  {
    TargetTypeName = targetType.Name;
  }

  /// <summary>
  /// Specifies mapping of the model enum type to one of the types used in interop assembly.
  /// </summary>
  /// <param name="targetTypeName">The type name to be associated with the decorated Enum type when converted to/from interop assembly.</param>
  public InteropEnumTypeAttribute(string targetTypeName)
  {
    TargetTypeName = targetTypeName;
  }

  /// <summary>
  /// The full type name associated with the decorated enum.
  /// </summary>
  public string TargetTypeName { [DebuggerStepThrough] get; }

}
