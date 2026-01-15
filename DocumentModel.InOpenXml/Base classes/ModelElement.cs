#pragma warning disable CS0659  
namespace DocumentModel;

/// <summary>
/// Base class for all model elements, providing property change notification support.
/// </summary>
public abstract class ModelElement : INotifyPropertyChanged, IEquatable<ModelElement>
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  protected ModelElement()
  {
  }

  /// <summary>
  /// Occurs when a property value changes. Can be subscribed to by listeners to receive notifications of property changes.
  /// </summary>
  public event PropertyChangedEventHandler? PropertyChanged;

  /// <summary>
  /// Updates data and raises a property changed notification for the specified property.
  /// </summary>
  /// <remarks>Call this method to notify listeners that a property value has changed, typically when
  /// implementing the INotifyPropertyChanged interface in data-binding scenarios.</remarks>
  /// <param name="propertyName">The name of the property that has changed. Cannot be null or empty.</param>
  public void NotifyPropertyChanged(string propertyName)
  {
    UpdateData(propertyName);
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }

  /// <summary>
  /// Raises a property changed notification for the specified property.
  /// </summary>
  /// <remarks>Call this method to notify listeners that a property value has changed, typically when
  /// implementing the INotifyPropertyChanged interface in data-binding scenarios.</remarks>
  /// <param name="propertyName">The name of the property that has changed. Cannot be null or empty.</param>
  public void OnPropertyChanged(string propertyName)
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }

  /// <summary>
  /// Updates the specified field with a new value and raises a property change notification if the value has changed.
  /// </summary>
  /// <remarks>This method is typically used in property setters to implement the INotifyPropertyChanged
  /// pattern. The property change notification is only raised if the field value actually changes.</remarks>
  /// <param name="field">A reference to the field to be updated. The field will be set to <paramref name="newValue"/> if its current value
  /// is not equal to <paramref name="newValue"/>.</param>
  /// <param name="newValue">The new value to assign to the field. If the value differs from the current field value, the field is updated and
  /// a property change notification is triggered.</param>
  /// <param name="propertyName">The name of the property associated with the field. Used to identify which property has changed when raising the
  /// notification.</param>
  protected void UpdateField<FieldType>(ref FieldType field, FieldType? newValue, string propertyName)
  {
    if (!Equals(field, newValue))
    {
      field = newValue!;
      NotifyPropertyChanged(propertyName);
    }
  }

  /// <summary>
  /// Determines whether the current ModelElement is equal to another ModelElement instance.
  /// </summary>
  /// <param name="other">The ModelElement to compare with the current instance. Can be null.</param>
  /// <returns>true if the specified ModelElement is equal to the current instance; otherwise, false.</returns>
  public bool Equals(ModelElement? other)
  {
    if (other is null) return false;
    if (ReferenceEquals(this, other)) return true;
    return DeepComparer.DeepEqual(this, other);
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current ModelElement instance.
  /// </summary>
  /// <remarks>Equality is determined by comparing the runtime type and the values of the ModelElement. This
  /// method overrides Object.Equals(Object).</remarks>
  /// <param name="obj">The object to compare with the current ModelElement instance.</param>
  /// <returns>true if the specified object is a ModelElement and is equal to the current instance; otherwise, false.</returns>
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
  public override bool Equals(object? obj)
  {
    if (obj is null) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != GetType()) return false;
    return DeepComparer.DeepEqual(this.GetType(), this, obj);
  }

  ///// <summary>
  ///// When implemented in a derived class, loads data from the underlying source into the current instance.
  ///// </summary>
  ///// <remarks>This method must be overridden in a derived class to define how data is loaded. The specific data
  ///// source and loading behavior depend on the implementation.</remarks>
  //public abstract void LoadData();

  /// <summary>
  /// Populates the current model element's properties with values from the specified Open XML element.
  /// </summary>
  /// <remarks>This method maps properties from the provided Open XML element to the corresponding properties of
  /// the model element. Only writable properties are updated. Override this method in a derived class to customize the
  /// data loading behavior.</remarks>
  /// <param name="openXmlElement">The Open XML element containing the data to load into the model element. Must be compatible with the current model
  /// element type.</param>
  public void LoadData(object openXmlElement)
  {
    var currentType = GetType();
    var openXmlType = OpenXmlTypeMap.GetOpenXmlTypeForModelElementType(currentType);
    if (openXmlType == null) return;
    foreach (var modelProperty in currentType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
    {
      if (modelProperty.CanWrite)
      {
        var openXmlProperty = OpenXmlPropertyMap.GetOpenXmlPropertyForModelElementProperty(modelProperty, openXmlType);
        if (openXmlProperty is null || !openXmlProperty.CanRead) continue;
        var value = openXmlProperty.GetValue(openXmlElement);
        if (value != null && !modelProperty.PropertyType.IsInstanceOfType(value))
        {
          value = Convert.ChangeType(value, modelProperty.PropertyType.GetNotNullableType());
        }
        modelProperty.SetValue(this, value);
      }
    }
  }

  /// <summary>
  /// Updates the specified Open XML element with the current values of this model's public properties.
  /// </summary>
  /// <remarks>This method maps each public property of the model to a corresponding property on the Open XML
  /// element and sets its value. Derived classes can override this method to customize the update behavior. The method
  /// does not perform validation on the Open XML element; callers should ensure it is compatible with the model
  /// type.</remarks>
  /// <param name="openXmlElement">The Open XML element to update with property values from this model. Must not be null.</param>
  public void UpdateData(object openXmlElement)
  {
    var currentType = GetType();
    var openXmlType = OpenXmlTypeMap.GetOpenXmlTypeForModelElementType(currentType) ?? openXmlElement.GetType();
    foreach (var modelProperty in currentType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
    {
      UpdateData(modelProperty, openXmlElement, openXmlType);
    }
  }

  /// <summary>
  /// Updates the value of the specified property in the underlying Open XML element, if it is available.
  /// </summary>
  /// <remarks>If the underlying Open XML element is not available, no update is performed. This method does not
  /// throw an exception if the property or element is missing.</remarks>
  /// <param name="propertyName">The name of the property to update. This value cannot be null.</param>
  public virtual void UpdateData(string propertyName)
  {
    var updatableElement = GetUpdatableOpenXmlElement();
    if (updatableElement is not null)
    {
      UpdateData(propertyName, updatableElement);
    }
  }

  /// <summary>
  /// Retrieves the Open XML element that can be updated by the derived class.  
  /// </summary>
  /// <remarks>Derived classes should override this method to return the Open XML element that supports
  /// modification. The returned object is typically used to apply changes to the document structure or
  /// content.</remarks>
  /// <returns>An object representing the updatable Open XML element. The specific type and structure depend on the
  /// implementation in the derived class.</returns>
  protected virtual object? GetUpdatableOpenXmlElement() => null;

  /// <summary>
  /// Updates the value of the specified property on the current model and synchronizes it with the corresponding Open
  /// XML element.
  /// </summary>
  /// <remarks>If the specified property is readable, its value is propagated to the corresponding property on
  /// the Open XML element. This method does not update write-only properties.</remarks>
  /// <param name="propertyName">The name of the property to update and synchronize. Must refer to a public instance property of the current model.</param>
  /// <param name="openXmlElement">The Open XML element associated with the property. This parameter is used to identify the target element for
  /// synchronization.</param>
  /// <exception cref="ArgumentException">Thrown if <paramref name="propertyName"/> does not correspond to a public instance property on the current model
  /// type.</exception>
  public void UpdateData(string propertyName, object openXmlElement)
  {
    var currentType = GetType();
    var openXmlType = OpenXmlTypeMap.GetOpenXmlTypeForModelElementType(currentType) ?? openXmlElement.GetType();
    var modelProperty = currentType.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
    if (modelProperty is not null && modelProperty.CanRead)
    {
      UpdateData(modelProperty, openXmlElement, openXmlType);
    }
  }

  /// <summary>
  /// Updates the specified Open XML element's property with the value from the given model property.
  /// </summary>
  /// <param name="modelProperty">The model property to update from.</param>
  /// <param name="openXmlElement">The Open XML element to update.</param>
  /// <param name="openXmlType">The Open XML type of the element.</param>
  private void UpdateData(PropertyInfo modelProperty, object openXmlElement, Type openXmlType)
  {
    var openXmlProperty = OpenXmlPropertyMap.GetOpenXmlPropertyForModelElementProperty(modelProperty, openXmlType);
    if (openXmlProperty is not null && openXmlProperty.CanWrite)
    {
      var value = modelProperty.GetValue(this);
      if (value != null && !openXmlProperty.PropertyType.IsInstanceOfType(value))
      {
        value = Convert.ChangeType(value, openXmlProperty.PropertyType);
      }
      openXmlProperty.SetValue(openXmlElement, value);
      return;
    }
    var setMappedMethod = OpenXmlPropertyMap.GetMappedMethod(modelProperty);
    if (setMappedMethod != null)
    {
      var targetParameters = setMappedMethod.GetParameters();
      if (targetParameters.Length == 1)
      {
        var value = modelProperty.GetValue(this);
        if (value != null && !targetParameters[0].ParameterType.IsInstanceOfType(value))
        {
          value = Convert.ChangeType(value, targetParameters[0].ParameterType);
        }
        if (setMappedMethod.DeclaringType == openXmlElement.GetType())
        {
          setMappedMethod.Invoke(openXmlElement, [value]);
        }
        else if (setMappedMethod.DeclaringType == this.GetType())
        {
          setMappedMethod.Invoke(this, [value]);
        }
      }
    }
  }

}