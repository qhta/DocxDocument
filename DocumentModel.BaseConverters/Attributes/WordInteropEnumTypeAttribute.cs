namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies mapping of the model enum type to one of the types used in Microsoft.Office.Interop.Word.
/// </summary>
[AttributeUsage(AttributeTargets.Enum, Inherited = true, AllowMultiple = true)]
public class WordInteropEnumTypeAttribute: Attribute
{
  /// <summary>
  /// Specifies mapping of the model enum type to one of the types used in Microsoft.Office.Interop.Word.
  /// </summary>
  /// <param name="targetType">The type to be associated with the decorated Enum type when converted to/from Microsoft.Office.Interop.Word.</param>
  public WordInteropEnumTypeAttribute(Type targetType)
  {
    TargetTypeName = targetType.Name;
  }
  /// <summary>
  /// Specifies mapping of the model enum type to one of the types used in Microsoft.Office.Core.
  /// </summary>
  /// <param name="targetTypeName">The type name to be associated with the decorated Enum type when converted to/from Microsoft.Office.Interop.Word.</param>
  public WordInteropEnumTypeAttribute(string targetTypeName)
  {
    TargetTypeName = targetTypeName;
  }

  /// <summary>
  /// The Microsoft.Office.Interop.Word type name associated with the decorated enum.
  /// </summary>
  public string TargetTypeName { [DebuggerStepThrough] get; }

}
