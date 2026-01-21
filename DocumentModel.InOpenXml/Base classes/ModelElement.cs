#pragma warning disable CS0659  
namespace DocumentModel;

/// <summary>
/// Base class for all model elements, providing property change notification support.
/// </summary>
public abstract class ModelElement : INotifyPropertyChanged, IEquatable<ModelElement>, IChildItem, ICollectionItem
{
  static ModelElement()
  {
    RegisterOpenXmlConversion();
  }

  /// <summary>
  /// Registers conversion delegates for handling Guid values in OpenXml serialization and deserialization operations.
  /// </summary>
  /// <remarks>Call this method before performing OpenXml conversions involving Guid types to ensure correct
  /// serialization and deserialization. This method is typically invoked during application initialization and only
  /// needs to be called once per process.</remarks>
  public static void RegisterOpenXmlConversion()
  {
    OpenXmlConverter.ConvertFromOpenDelegates[typeof(Guid)] = ConvertGuidFromOpenXml;
    OpenXmlConverter.ConvertToOpenDelegates[typeof(Guid)] = ConvertToGuidOpenXml;
  }

  /// <summary>
  /// Converts an OpenXml element representing a GUID value to a .NET Guid object if possible.
  /// </summary>
  /// <remarks>If the OpenXml element does not contain a valid GUID string or the model type is not Guid, the
  /// method returns null. This method is intended for scenarios where OpenXml elements are mapped to strongly typed
  /// .NET models.</remarks>
  /// <param name="openXmlElement">The OpenXml element to convert. Should be a DX.StringValue containing a valid GUID string, or null.</param>
  /// <param name="modelType">The target model type. Must be typeof(Guid) to perform the conversion.</param>
  /// <returns>A Guid object if the OpenXml element contains a valid GUID string and the model type is Guid; otherwise, null.</returns>
  private static object? ConvertGuidFromOpenXml(object? openXmlElement, Type modelType)
  {
    if (modelType == typeof(Guid))
      if (openXmlElement is DX.StringValue stringValue)
      {
        if (Guid.TryParse(stringValue.Value, out var guid))
          return guid;
      }
    return null;
  }

  /// <summary>
  /// Converts a <see cref="Guid"/> object to an OpenXml-compatible value if the specified type is supported.
  /// </summary>
  /// <remarks>The method returns <see langword="null"/> if the input object is not a <see cref="Guid"/> or if
  /// the specified OpenXml type is not supported. The string representation uses the "B" format and is converted to
  /// uppercase.</remarks>
  /// <param name="modelObject">The object to convert. Must be a <see cref="Guid"/> instance to perform the conversion; otherwise, no conversion
  /// is performed.</param>
  /// <param name="openXmlType">The target OpenXml type to convert to. Currently, only <see cref="DX.StringValue"/> is supported.</param>
  /// <returns>An instance of <see cref="DX.StringValue"/> containing the uppercase, bracketed string representation of the <see
  /// cref="Guid"/> if conversion is successful; otherwise, <see langword="null"/>.</returns>
  private static object? ConvertToGuidOpenXml(object? modelObject, Type openXmlType)
  {
    if (modelObject is Guid guid)
      if (openXmlType == typeof(DX.StringValue))
      {
        var text = guid.ToString("B").ToUpper();
        return new DX.StringValue(text);
      }
    return null;
  }

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
    UpdatePropertyData(propertyName);
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
  /// <param name="field">A reference to the field to be updated. The field will be set to <paramref name="value"/> if its current value
  /// is not equal to <paramref name="value"/>.</param>
  /// <param name="value">The new value to assign to the field. If the value differs from the current field value, the field is updated and
  /// a property change notification is triggered.</param>
  /// <param name="propertyName">The name of the property associated with the field. Used to identify which property has changed when raising the
  /// notification.</param>
  protected void UpdateField<FieldType>(ref FieldType? field, FieldType? value, string propertyName)
  {
    if (typeof(FieldType).Name.StartsWith("AttachedTemplate")) Debug.Assert(true);

    if (value is string stringValue && stringValue.Length == 0)
      value = default;
    if (!Equals(field, value))
    {
      if (field is IWordprocessingDocumentAware oldValue)
        oldValue.Detach();
      if (value is IChildItem childItem && childItem.Parent == null)
        if (!Object.ReferenceEquals(value, this))
          childItem.Parent = this;
      if (value is IWordprocessingDocumentAware newValue
          && this is IWordprocessingDocumentAware thisElement && thisElement.WordprocessingDocument != null)
        newValue.AttachAndUpdate(thisElement.WordprocessingDocument);
      field = value;
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
    return DeepComparer.Equals(this, other);
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
    return DeepComparer.Equals(this.GetType(), this, obj);
  }

  /// <summary>
  /// Populates the current model element's properties with values from the specified Open XML element.
  /// </summary>
  /// <remarks>This method maps properties from the provided Open XML element to the corresponding properties of
  /// the model element. Only writable properties are updated. Override this method in a derived class to customize the
  /// data loading behavior.</remarks>
  /// <param name="openXmlElement">The Open XML element containing the data to load into the model element. Must be compatible with the current model
  /// element type.</param>
  public virtual void LoadData(object openXmlElement)
  {
    OpenXmlComplexTypeConverter.LoadData(this, openXmlElement, this.GetType());
  }

  /// <summary>
  /// Updates the specified Open XML element with the current values of this model's public properties.
  /// </summary>
  /// <remarks>This method maps each public property of the model to a corresponding property on the Open XML
  /// element and sets its value. Derived classes can override this method to customize the update behavior. The method
  /// does not perform validation on the Open XML element; callers should ensure it is compatible with the model
  /// type.</remarks>
  /// <param name="openXmlElement">The Open XML element to update with property values from this model. Must not be null.</param>
  public virtual void UpdateData(object openXmlElement)
  {
    var openXmlType = this.GetType().GetCustomAttribute<OpenXmlTypeAttribute>()?.Type ?? openXmlElement.GetType();
    OpenXmlComplexTypeConverter.UpdateData(this, openXmlElement, openXmlType);
  }

  /// <summary>
  /// Updates the value of the specified property in the underlying Open XML element, if it is available.
  /// </summary>
  /// <remarks>If the underlying Open XML element is not available, no update is performed. This method does not
  /// throw an exception if the property or element is missing.</remarks>
  /// <param name="propertyName">The name of the property to update. This value cannot be null.</param>
  public virtual void UpdatePropertyData(string propertyName)
  {
    var updatableElement = GetUpdatableOpenXmlElement();
    if (updatableElement == null)
      return;
    var modelProperty = this.GetType().GetProperty(propertyName);
    if (modelProperty == null) return;
    var openXmlType = updatableElement.GetType()!;
    var openXmlProperty = OpenXmlPropertyMap.GetOpenXmlPropertyForModelProperty(modelProperty, openXmlType);
    if (openXmlProperty == null) return;
    OpenXmlComplexTypeConverter.UpdateOpenXmlProperty(this, modelProperty, updatableElement, openXmlProperty);
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
  /// Parent object that contains this item.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public object? Parent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }


  /// <summary>
  /// Optional collection that contains this item.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public object? Collection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}