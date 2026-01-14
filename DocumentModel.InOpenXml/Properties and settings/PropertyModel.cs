namespace DocumentModel;

/// <summary>
/// Information about a property that is compatible with PropertyDescriptor.
/// </summary>
public class PropertyModel: PropertyDescriptor
{
  private readonly PropertyInfo _propertyInfo;

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="propertyInfo">Reflected property info</param>
  public PropertyModel(PropertyInfo propertyInfo) : base(propertyInfo.Name, [])
  {
    _propertyInfo = propertyInfo;
  }

  /// <summary>
  /// Component to which this property is assigned.
  /// </summary>
  public object? Component { get; set; }

  /// <summary>
  /// Determines whether the value of this property can be reset to its default value for the specified component.
  /// </summary>
  /// <remarks>A property can typically be reset if it has a DefaultValueAttribute or if it is a reference type
  /// (other than string) or a nullable value type. This method does not actually reset the value; it only indicates
  /// whether resetting is supported.</remarks>
  /// <param name="component">The component for which to check if the property value can be reset.</param>
  /// <returns>true if the property can be reset to its default value for the specified component; otherwise, false.</returns>
  public override bool CanResetValue(object component)
  {
    // Check if the property has a default value attribute
    var defaultValueAttr = _propertyInfo.GetCustomAttribute<DefaultValueAttribute>();
    if (defaultValueAttr != null)
      return true;
    
    // For reference types (except string), can reset to null
    if (!_propertyInfo.PropertyType.IsValueType || 
        Nullable.GetUnderlyingType(_propertyInfo.PropertyType) != null)
      return true;
    
    return false;
  }

  /// <summary>
  /// Gets the current value of the property for the specified component instance.
  /// </summary>
  /// <param name="component">The object instance from which to retrieve the property value. Can be null.</param>
  /// <returns>The value of the property for the specified component, or null if the component is null.</returns>
  public override object? GetValue(object? component)
  {
    if (component == null)
      return null;
    
    return _propertyInfo.GetValue(component);
  }

  /// <summary>
  /// Resets the value of the property on the specified component to its default value.
  /// </summary>
  /// <remarks>If the property is decorated with a <see cref="DefaultValueAttribute"/>, the value is reset to
  /// the specified default. For reference types and nullable value types, the value is reset to <see langword="null"/>.
  /// For non-nullable value types, the value is reset to the type's default value.</remarks>
  /// <param name="component">The object whose property value is to be reset. This parameter cannot be null.</param>
  public override void ResetValue(object? component)
  {
    if (component == null)
      return;
    
    // Try to get default value from attribute
    var defaultValueAttr = _propertyInfo.GetCustomAttribute<DefaultValueAttribute>();
    if (defaultValueAttr != null)
    {
      _propertyInfo.SetValue(component, defaultValueAttr.Value);
      return;
    }
    
    // For reference types, reset to null
    if (!_propertyInfo.PropertyType.IsValueType)
    {
      _propertyInfo.SetValue(component, null);
      return;
    }
    
    // For nullable value types, reset to null
    if (Nullable.GetUnderlyingType(_propertyInfo.PropertyType) != null)
    {
      _propertyInfo.SetValue(component, null);
      return;
    }
    
    // For value types, reset to default(T)
    _propertyInfo.SetValue(component, Activator.CreateInstance(_propertyInfo.PropertyType));
  }

  /// <summary>
  /// Sets the value of the property for the specified component instance.
  /// </summary>
  /// <param name="component">The object instance on which to set the property value. Can be null.</param>
  /// <param name="value">The value to set for the property.</param>
  public override void SetValue(object? component, object? value)
  {
    if (component == null)
      return;
    
    _propertyInfo.SetValue(component, value);
  }

  /// <summary>
  /// Determines whether the value of the property for the specified component should be serialized.
  /// </summary>
  /// <remarks>This method checks for a DefaultValueAttribute on the property. If present, the property is
  /// serialized only if its value differs from the specified default. For reference types and nullable value types, the
  /// property is serialized if its value is not null. For other value types, the property is serialized if its value
  /// differs from the type's default value.</remarks>
  /// <param name="component">The component instance whose property value is evaluated for serialization. Cannot be null.</param>
  /// <returns>true if the property's value differs from its default value and should be serialized; otherwise, false.</returns>
  public override bool ShouldSerializeValue(object? component)
  {
    if (component == null)
      return false;
    
    var currentValue = _propertyInfo.GetValue(component);
    
    // Check if there's a default value attribute
    var defaultValueAttr = _propertyInfo.GetCustomAttribute<DefaultValueAttribute>();
    if (defaultValueAttr != null)
    {
      // Serialize if value differs from default
      return !Equals(currentValue, defaultValueAttr.Value);
    }
    
    // For reference types, serialize if not null
    if (!_propertyInfo.PropertyType.IsValueType)
      return currentValue != null;
    
    // For nullable value types, serialize if has value
    if (Nullable.GetUnderlyingType(_propertyInfo.PropertyType) != null)
      return currentValue != null;
    
    // For value types, compare with default(T)
    var defaultValue = Activator.CreateInstance(_propertyInfo.PropertyType);
    return !Equals(currentValue, defaultValue);
  }

  /// <summary>
  /// Gets the type of the object that this property descriptor is associated with.
  /// </summary>
  public override Type ComponentType => _propertyInfo.DeclaringType ?? typeof(object);
  
  /// <summary>
  /// Gets a value indicating whether the property is read-only.
  /// </summary>
  /// <remarks>A property is considered read-only if it does not have a public setter or if a set accessor is
  /// not defined. Use this property to determine whether the value of the property can be changed.</remarks>
  public override bool IsReadOnly => !_propertyInfo.CanWrite || _propertyInfo.GetSetMethod() == null;
  
  /// <summary>
  /// Gets the type of the property represented by this instance.
  /// </summary>
  public override Type PropertyType => _propertyInfo.PropertyType;

  /// <summary>
  /// Gets the display name from propertyInfo.
  /// </summary>
  public override string Name =>_propertyInfo.Name;

  /// <summary>
  /// Gets the display name from propertyInfo.
  /// </summary>
  public override string DisplayName => _propertyInfo.Name;
}