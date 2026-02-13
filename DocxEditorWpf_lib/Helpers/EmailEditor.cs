using Syncfusion.Windows.Controls.Input;

namespace DocxEditor.Helpers;

/// <summary>
/// Custom editor for email address properties using a Syncfusion masked edit control.
/// </summary>
/// <remarks>
/// This editor provides a masked input for editing email addresses within a property grid.
/// </remarks>
public class EmailEditor : ITypeEditor
{
  SfMaskedEdit maskededit;
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
      BindingOperations.SetBinding(maskededit, SfMaskedEdit.ValueProperty, binding);
    }
    else
    {
      maskededit.IsEnabled = false;
      var binding = new Binding("Value")
      {
        Source = info,
        ValidatesOnExceptions = true,
        ValidatesOnDataErrors = true
      };
      BindingOperations.SetBinding(maskededit, SfMaskedEdit.ValueProperty, binding);
    }
  }

  /// <summary>
  /// Creates and configures a Syncfusion masked edit control for email address editing based on the provided property information.
  /// </summary>
  /// <param name="propertyInfo">Reflection information about the property being edited.</param>
  /// <returns>The configured SfMaskedEdit control instance.</returns>
  public object Create(PropertyInfo propertyInfo) => Init();

  /// <summary>
  /// Creates and configures a Syncfusion masked edit control for email address editing based on the provided
  /// property descriptor.
  /// </summary>
  /// <param name="PropertyDescriptor">Descriptor for the property being edited.</param>
  public object Create(PropertyDescriptor PropertyDescriptor) => Init();

  /// <summary>
  /// Initializes and configures a new instance of the SfMaskedEdit control for email address validation using a regular
  /// expression mask.
  /// </summary>
  /// <returns>A configured SfMaskedEdit control that validates input against a standard email address pattern.</returns>
  private object Init()
  {
    maskededit = new SfMaskedEdit();
    maskededit.MaskType = MaskType.RegEx;
    maskededit.Mask = "[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}";
    return maskededit;
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
    return false;
  }

}

