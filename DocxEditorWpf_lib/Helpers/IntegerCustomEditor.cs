namespace DocxEditor.Helpers;

/// <summary>
/// Provides a custom editor for integer properties, enabling specialized editing functionality for integer values
/// within property grids or similar UI components.
/// </summary>
public class IntegerCustomEditor: ITypeCustomEditor
{
  public ITypeEditor Editor { get; set; } = new IntegerEditor();

  public ObservableCollection<string> Properties { get; set; } = new ObservableCollection<string>();

  public Type PropertyType { get; set; } = typeof(int);

  public bool HasPropertyType { get; set; } = true;

  public Type EditorType { get; set; } = typeof(IntegerEditor);
}