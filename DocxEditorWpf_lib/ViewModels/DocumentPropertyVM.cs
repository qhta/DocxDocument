namespace DocxEditor.ViewModels;

/// <summary>
/// ViewModel representing a document property.
/// </summary>
public class DocumentPropertyVM: ViewModel<PropertyModel>, IPropertyVM  
{
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="model"></param>
  public DocumentPropertyVM(PropertyModel model) : base(model)
  {
  }

  /// <summary>
  /// Name of the property.
  /// </summary>
  public string Name
  {
    get => Model.Name ?? string.Empty;
  }

  /// <summary>
  /// Value of the property.
  /// </summary>
  public object? Value
  {
    get => Model.GetValue(Model.Component);
    set
    {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  /// Value type of the property.
  /// </summary>
  public Type ValueType
  {
    get => Model.PropertyType;
    set { }
  }

  /// <summary>
  /// Empty property has no value or an empty string.
  /// </summary>
  public bool IsEmpty => Value == null || (Value is string str && string.IsNullOrEmpty(str));

  public string Category
  {
    get => Model.Category ?? string.Empty;
  }
}