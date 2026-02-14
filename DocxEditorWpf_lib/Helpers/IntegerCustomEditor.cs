namespace DocxEditor.Helpers;

/// <summary>
/// Custom editor for integer properties, enabling specialized editing functionality for integer values in property grids or similar UI components.
/// </summary>
public class IntegerCustomEditor : ITypeCustomEditor
{
  /// <summary>
  /// Editor instance used for editing integer values.
  /// </summary>
  public ITypeEditor Editor { get; set; } = new IntegerEditor();

  /// <summary>
  /// Collection of property names associated with this custom editor.
  /// </summary>
  public ObservableCollection<string> Properties { get; set; } = new ObservableCollection<string>();

  /// <summary>
  /// Type of property handled by this editor, representing integer values.
  /// </summary>
  public Type PropertyType { get; set; } = typeof(int);

  /// <summary>
  /// Indicates whether the property type is explicitly defined for this editor.
  /// </summary>
  public bool HasPropertyType { get; set; } = true;

  /// <summary>
  /// Type of the editor used for integer properties.
  /// </summary>
  public Type EditorType { get; set; } = typeof(IntegerEditor);
}
