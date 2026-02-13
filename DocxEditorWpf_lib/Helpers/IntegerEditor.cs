namespace DocxEditor.Helpers;

/// <summary>
/// Custom editor for integer values in a property grid using Syncfusion UpDown control.
/// </summary>
/// <remarks>
/// This editor provides a numeric up/down interface for editing integer properties within a property grid.
/// </remarks>

public class IntegerEditor : ITypeEditor
{
  public IntegerEditor()
  {
    Init();
  }

  UpDown upDown = new UpDown();

  /// <summary>
  /// Attaches the editor to the specified property, configuring binding and enabling/disabling based on writability.
  /// </summary>
  /// <param name="property">The property view item to attach to.</param>
  /// <param name="info">The property item containing metadata and value information.</param>
  public void Attach(PropertyViewItem property, PropertyItem info)
  {
    if (info.CanWrite)
    {
      var binding = new Binding("Value")
      {
        Mode = BindingMode.TwoWay,
        Source = info,
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
  public object Create(PropertyInfo propertyInfo) => Init();

  /// <summary>
  /// Creates and configures a Syncfusion UpDown control for integer editing based on the provided property descriptor.
  /// </summary>
  /// <returns>The configured UpDown control instance.</returns>
  /// <param name="PropertyDescriptor">Descriptor for the property being edited.</param>
  public object Create(PropertyDescriptor PropertyDescriptor) => Init();

  /// <summary>
  /// Initializes and configures a new instance of the UpDown control with default settings.
  /// </summary>
  private object Init()
  {
    upDown = new UpDown();
    upDown.ApplyZeroColor = false;
    upDown.MinValue = 0;
    upDown.MaxValue = 100;
    upDown.NumberDecimalDigits = 0;
    return upDown;
  }
  /// <summary>
  /// Detaches the editor from the specified property. No operation is performed in this implementation.
  /// </summary>
  /// <param name="property">The property view item to detach from.</param>
  public void Detach(PropertyViewItem property)
  {

  }

  /// <summary>
  /// Indicates whether the property grid should handle key down events for this editor.
  /// </summary>
  /// <param name="key">The key pressed by the user.</param>
  /// <returns>Always returns false, allowing default handling.</returns>
  public bool ShouldPropertyGridTryToHandleKeyDown(Key key)
  {
    return true;
  }

}