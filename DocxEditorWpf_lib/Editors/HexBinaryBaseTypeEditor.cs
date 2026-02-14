using Qhta.TypeUtils;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Media;

namespace DocxEditor;

/// <summary>
/// Custom editor for email address properties using a Syncfusion masked edit control.
/// </summary>
/// <remarks>
/// This editor provides a masked input for editing email addresses within a property grid.
/// </remarks>
public class HexBinaryBaseTypeEditor : BaseTypeEditor
{
  private readonly SfMaskedEdit maskedEdit = new SfMaskedEdit
  {
    //BorderThickness = new Thickness(0,0,0,0),
    BorderBrush = Brushes.Transparent,
    Padding = new Thickness(0,3,0,3),
    ValidationMode = InputValidationMode.LostFocus, 
  };
  private Brush? defaultBorderBrush;
  private Thickness defaultBorderThickness;
  private bool isValidationHandlerAttached;
  private readonly HexBinaryEvenLengthValidationRule evenLengthRule = new();
  private ValidationError? evenLengthError;

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
        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
        Source = info,
        Converter = new HexBinaryValueConverter(),
        ConverterParameter = info.PropertyType,
        ValidatesOnExceptions = true,
        ValidatesOnDataErrors = true,
        NotifyOnValidationError = true,
      };
      BindingOperations.SetBinding(maskedEdit, SfMaskedEdit.ValueProperty, binding);
    }
    else
    {
      maskedEdit.IsEnabled = false;
      var binding = new Binding("Value")
      {
        Source = info,
        Converter = new HexBinaryValueConverter(),
        ValidatesOnExceptions = true,
        ValidatesOnDataErrors = true
      };
      BindingOperations.SetBinding(maskedEdit, SfMaskedEdit.ValueProperty, binding);
    }
  }

  /// <summary>
  /// Creates and configures a Syncfusion masked edit control for email address editing based on the provided property information.
  /// </summary>
  /// <param name="propertyInfo">Reflection information about the property being edited.</param>
  /// <returns>The configured SfMaskedEdit control instance.</returns>
  public override object Create(PropertyInfo propertyInfo) => Init(propertyInfo.PropertyType);

  /// <summary>
  /// Creates and configures a Syncfusion masked edit control for email address editing based on the provided
  /// property descriptor.
  /// </summary>
  /// <param name="propertyDescriptor">Descriptor for the property being edited.</param>
  public override object Create(PropertyDescriptor propertyDescriptor) => Init(propertyDescriptor.PropertyType);

  /// <summary>
  /// Initializes and configures a new instance of the SfMaskedEdit control for email address validation using a regular
  /// expression mask.
  /// </summary>
  /// <returns>A configured SfMaskedEdit control that validates input against a standard email address pattern.</returns>
  private object Init(Type propertyType)
  {
    propertyType = propertyType.GetNotNullableType();
    EnsureValidationHandler();
    maskedEdit.MaskType = MaskType.RegEx;
    int digits = 0;
    if (propertyType==typeof(HexChar))
      digits = 4;
    else if (propertyType==typeof(HexInt))
      digits = 8;
    else if (propertyType == typeof(HexLong))
      digits = 16;
    maskedEdit.Mask = "[0-9A-Fa-f]" + (digits==0 ? "*" : $"{{{digits}}}");
    return maskedEdit;
  }

  private void EnsureValidationHandler()
  {
    if (isValidationHandlerAttached)
    {
      return;
    }

    defaultBorderBrush = Brushes.Transparent;
     // maskedEdit.BorderBrush;
    defaultBorderThickness = maskedEdit.BorderThickness;
    Validation.AddErrorHandler(maskedEdit, OnMaskedEditValidationError);
    maskedEdit.TextChanged += OnMaskedEditTextChanged;
    isValidationHandlerAttached = true;
  }

  private void OnMaskedEditTextChanged(object sender, TextChangedEventArgs e)
  {
    var bindingExpression = maskedEdit.GetBindingExpression(SfMaskedEdit.ValueProperty);
    if (bindingExpression == null)
    {
      return;
    }

    var result = evenLengthRule.Validate(maskedEdit.Text ?? string.Empty, CultureInfo.CurrentCulture);
    if (result.IsValid)
    {
      if (evenLengthError != null)
      {
        Validation.ClearInvalid(bindingExpression);
        evenLengthError = null;
      }
      return;
    }

    evenLengthError = new ValidationError(evenLengthRule, bindingExpression, result.ErrorContent, null);
    Validation.MarkInvalid(bindingExpression, evenLengthError);
  }

  private void OnMaskedEditValidationError(object?
    sender, ValidationErrorEventArgs e)
  {
    if (Validation.GetHasError(maskedEdit))
    {
      maskedEdit.BorderBrush = Brushes.Red;
      return;
    }

    maskedEdit.BorderBrush = defaultBorderBrush;
    maskedEdit.BorderThickness = defaultBorderThickness;
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
    return true;
  }

}

