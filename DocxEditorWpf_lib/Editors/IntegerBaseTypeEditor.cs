namespace DocxEditor;

/// <summary>
/// Custom editor for integer values in a property grid using Syncfusion UpDown control.
/// </summary>
/// <remarks>
/// This editor provides a numeric up/down interface for editing integer properties within a property grid.
/// </remarks>

public class IntegerBaseTypeEditor : BaseTypeEditor
{
  /// <summary>
  /// Default constructor needed by WPF.
  /// </summary>
  public IntegerBaseTypeEditor()
  {
  }

  private readonly UpDown upDown = new UpDown 
    { ApplyZeroColor = false, 
      NumberDecimalDigits = 0, 
      UseNullOption = true, 
      NullValue = null};

  /// <summary>
  /// Attaches the editor to the specified property, configuring binding and enabling/disabling based on writability.
  /// </summary>
  /// <param name="property">The property view item to attach to.</param>
  /// <param name="info">The property item containing metadata and value information.</param>
  public override void Attach(PropertyViewItem property, PropertyItem info)
  {
    if (info.CanWrite)
    {
      var binding = new Binding("Value")
      {
        Mode = BindingMode.TwoWay,
        Source = info,
        Converter = new IntegerValueConverter(),
        ValidatesOnExceptions = true,
        ValidatesOnDataErrors = true
      };
      BindingOperations.SetBinding(upDown, UpDown.ValueProperty, binding);
    }
    else
    {
      upDown.IsEnabled = false;
      var binding = new Binding("Value")
      {
        Source = info,
        Converter = new IntegerValueConverter(),
        ValidatesOnExceptions = true,
        ValidatesOnDataErrors = true
      };
      BindingOperations.SetBinding(upDown, UpDown.ValueProperty, binding);
    }
  }

  /// <summary>
  /// Creates and configures a Syncfusion UpDown control for integer editing based on the provided property information.
  /// </summary>
  /// <param name="propertyInfo">Reflection information about the property being edited.</param>
  /// <returns>The configured UpDown control instance.</returns>
  public override object Create(PropertyInfo propertyInfo)
  {
    return upDown;
  }

  /// <summary>
  /// Creates and configures a Syncfusion UpDown control for integer editing based on the provided property descriptor.
  /// </summary>
  /// <returns>The configured UpDown control instance.</returns>
  /// <param name="propertyDescriptor">Descriptor for the property being edited.</param>
  public override object Create(PropertyDescriptor propertyDescriptor)
  {
    return upDown;
  }


  /// <summary>
  /// Detaches the editor from the specified property. No operation is performed in this implementation.
  /// </summary>
  /// <param name="property">The property view item to detach from.</param>
  public override void Detach(PropertyViewItem property)
  {

  }

  /// <summary>
  /// Indicates whether the property grid should handle key down events for this editor.
  /// </summary>
  /// <param name="key">The key pressed by the user.</param>
  /// <returns>Always returns false, allowing default handling.</returns>
  public override bool ShouldPropertyGridTryToHandleKeyDown(Key key)
  {
    return false;
  }

}