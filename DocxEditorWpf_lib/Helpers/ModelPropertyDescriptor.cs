using System.Runtime.CompilerServices;

namespace DocxEditor.Helpers;

/// <summary>
/// A property descriptor for a document property, which provides information about the property
/// and allows getting and setting its value.
/// </summary>
public class ModelPropertyDescriptor : PropertyDescriptor
{
  private readonly PropertyModel propertyModel;

  private readonly PropertiesProvider propertiesProvider;

  #region Constructors

  /// <summary>
  /// Initializes a new instance of the DocumentPropertyDescriptor class
  /// with the specified properties provider and property model.
  /// </summary>
  /// <param name="propertiesProvider"></param>
  /// <param name="propertyModel"></param>
  public ModelPropertyDescriptor(PropertiesProvider propertiesProvider,
    PropertyModel propertyModel)
    : base(propertyModel.Name, propertyModel.PropertyAttributes)
  {
    this.propertiesProvider = propertiesProvider;
    this.propertyModel = propertyModel;
  }

  #endregion

  #region Properties

  /// <summary>
  /// Gets the type of the component associated with this provider.
  /// </summary>
  public override Type ComponentType => typeof(PropertiesProvider);

  /// <summary>
  /// Gets the display name of the property, which is used to show the property in the property grid.
  /// </summary>
  public override string DisplayName => propertiesProvider.GetDisplayName(propertyModel);

  /// <summary>
  /// Gets a value indicating whether the property is read-only.
  /// </summary>
  public override bool IsReadOnly => propertyModel.IsReadOnly;

  /// <summary>
  /// Gets the type of the property, which is used to determine how to display and edit the property in the property grid.
  /// </summary>
  public override Type PropertyType => propertyModel.PropertyType;


  #endregion

  #region Override members

  /// <summary>
  /// Component of the property model, which is used to get and set the property value. 
  /// </summary>
  public object? Component => propertyModel.Component;

  /// <summary>
  /// Determines whether the value of the specified component can be reset to its default state.
  /// </summary>
  /// <remarks>
  /// Component is passed to the property model, but is ignored there.
  /// </remarks>
  public override bool CanResetValue(object component) => Component != null && propertyModel.CanResetValue(Component);

  /// <summary>
  /// Gets the current value of the property for the specified component.
  /// </summary>
  /// <remarks>
  /// Null is passed as the component because the property model does not rely on a specific component instance to manage the property value,
  /// </remarks>
  public override object? GetValue(object? component) => propertyModel.GetValue(Component);

  /// <summary>
  /// Resets the value of the property to its default state for the specified component.
  /// </summary>
  /// <remarks>
  /// Null is passed as the component because the property model does not rely on a specific component instance to manage the property value,
  /// </remarks>
  public override void ResetValue(object component)
  {
    if (Component == null)
      return;

    propertyModel.ResetValue(Component);
    OnValueChanged(Component, EventArgs.Empty);
  }

  /// <summary>
  /// Sets the value of the property represented by this descriptor for the specified component.
  /// </summary>
  /// <remarks>
  /// Null is passed as the component because the property model does not rely on a specific component instance to manage the property value,
  /// </remarks>

  public override void SetValue(object? component, object? value)
  {
    propertyModel.SetValue(Component, value);
    OnValueChanged(Component, EventArgs.Empty);
  }

  /// <summary>
  /// Determines whether the value of the specified component should be persisted.
  /// </summary>
  /// <remarks>
  ///  Need to return false here to prevent the property grid from trying to persist the property value,
  /// </remarks>
  public override bool ShouldSerializeValue(object component) => Component != null && propertyModel.ShouldSerializeValue(Component);


  #endregion

}