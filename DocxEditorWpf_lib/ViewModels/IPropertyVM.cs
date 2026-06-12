namespace DocxEditor;

/// <summary>
/// Interface for any class representing a property in the ViewModel.
/// </summary>
public interface IPropertyVM
{
  /// <summary>
  /// Name of the property.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// Value of the property.
  /// </summary>
  public object? Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Value type of the property.
  /// </summary>
  public Type ValueType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines whether the property is empty
  /// </summary>
  public bool IsEmpty { get; }
}