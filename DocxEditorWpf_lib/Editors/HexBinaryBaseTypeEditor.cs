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

  /// <summary>
  /// Ensures that the validation event handlers are attached to the masked edit control. If the handlers are already
  /// attached, this method performs no action.
  /// </summary>
  /// <remarks>Call this method before performing validation on the masked edit control to guarantee that
  /// validation error and text change events are handled appropriately. This method also sets the default border
  /// appearance for the control, which may affect its visual feedback during validation.</remarks>
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

  /// <summary>
  /// Handles the TextChanged event for the masked edit control and validates the input to ensure it meets the even
  /// length requirement.
  /// </summary>
  /// <remarks>If the input does not satisfy the even length rule, the method marks the associated binding as
  /// invalid and provides error information. This helps ensure that only valid input is accepted by the
  /// control.</remarks>
  /// <param name="sender">The source of the event, typically the masked edit control whose text has changed.</param>
  /// <param name="args">The event data containing information about the text change.</param>
  private void OnMaskedEditTextChanged(object sender, TextChangedEventArgs args)
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

  /// <summary>
  /// Handles the validation error event for the masked edit control, updating its border appearance based on the
  /// current validation state.
  /// </summary>
  /// <remarks>If the masked edit control has a validation error, its border is set to red to indicate the error
  /// state. Otherwise, the border appearance is reset to its default values.</remarks>
  /// <param name="sender">The source of the event, typically the masked edit control that triggered the validation error.</param>
  /// <param name="args">The event data containing information about the validation error.</param>
  private void OnMaskedEditValidationError(object? sender, ValidationErrorEventArgs args)
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

