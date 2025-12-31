namespace DocxEditor.ViewModels;

/// <summary>
/// Interface for any class representing a property in the ViewModel.
/// </summary>
public interface IPropertyVM
{
  /// <summary>
  /// Name of the property.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Value of the property.
  /// </summary>
  public object? Value { get; set; }

  /// <summary>
  /// Value type of the property.
  /// </summary>
  public Type ValueType { get; set; }

  /// <summary>
  /// Determines whether the property is empty
  /// </summary>
  public bool IsEmpty { get; }
}