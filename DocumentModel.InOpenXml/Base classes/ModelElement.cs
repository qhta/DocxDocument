using DocumentModel.BaseConverters;

using InvalidOperationException = Qhta.TestHelper.InvalidOperationException;

#pragma warning disable CS0659
namespace DocumentModel;

/// <summary>
/// Base class for all model elements, providing property change notification support.
/// </summary>
[XmlRoot("ModelElement", Namespace = "DocumentModel")]
public abstract partial class ModelElement : INotifyPropertyChanged, IEquatable<ModelElement>, IChildItem,
  ICollectionItem, IModifiable, IUpdatable, INotificationSource, ILoadable, ISerializationEnabling, IEmptyCheckable,
  IPropertiesProvider, IModelObject
{
  static ModelElement()
  {
    RegisterOpenXmlConversion();
  }

  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  protected ModelElement()
  {
    PropertyChanged += ModelElement_PropertyChanged;
  }

  /// <summary>
  /// Initializes a new instance of the ModelElement class with the specified parent element. This constructor is used to establish a parent-child relationship between model elements.
  /// </summary>
  /// <param name="parent"></param>
  protected ModelElement(ModelElement parent) : this()
  {
    Parent = parent;
    if (this is IWordprocessingDocumentAware wordprocessingDocumentAware 
        && parent is IWordprocessingDocumentAware parentWordprocessingDocumentAware)
    {
      if (parentWordprocessingDocumentAware.WordprocessingDocument != null)
        wordprocessingDocumentAware.Attach(parentWordprocessingDocumentAware.WordprocessingDocument);
    }
  }

  /// <summary>
  /// Copy data f from the specified other instance to this instance. This method copies all public properties from the other instance to the current instance, and updates the underlying OpenXml element if applicable.
  /// </summary>
  /// <param name="otherInstance"></param>
  public virtual void CopyFrom(ModelElement otherInstance)
  {
    var modelType = otherInstance.GetType();
    foreach (var modelProperty in modelType.GetModelProperties())
    {
      var thisValue = modelProperty.GetValue(this);
      var otherValue = modelProperty.GetValue(otherInstance);
      if (thisValue is ModelElement thisElement && otherValue is ModelElement otherElement)
        thisElement.CopyFrom(otherElement);
      else
        modelProperty.SetValue(this, otherValue);
    }

    var updatableElement = GetUpdatableObject();
    if (updatableElement != null)
      UpdateData(updatableElement);
  }

  /// <summary>
  /// Passes the IsModified up to the parent IModifiable object.
  /// </summary>
  /// <param name = "sender">Sender object that raised the event.</param>
  /// <param name = "args">Event arguments containing the property name.</param>
  private void ModelElement_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (IsNotificationEnabled)
      if (args.PropertyName != nameof(IsModified))
        SetIsModified(true);
  }

  /// <summary>
  /// Registers conversion delegates for handling Guid values in OpenXml serialization and deserialization operations.
  /// </summary>
  /// <remarks>Call this method before performing OpenXml conversions involving Guid types to ensure correct
  /// serialization and deserialization. This method is typically invoked during application initialization and only
  /// needs to be called once per process.</remarks>
  public static void RegisterOpenXmlConversion()
  {
    OpenXmlModelConverter.ConvertFromOpenXmlDelegates[typeof(Guid)] = ConvertGuidFromOpenXml;
    OpenXmlModelConverter.ConvertToOpenXmlDelegates[typeof(Guid)] = ConvertToGuidOpenXml;
  }

  /// <summary>
  /// Converts an OpenXml element representing a GUID value to a .NET Guid object if possible.
  /// </summary>
  /// <remarks>If the OpenXml element does not contain a valid GUID string or the model type is not Guid, the
  /// method returns null. This method is intended for scenarios where OpenXml elements are mapped to strongly typed
  /// .NET models.</remarks>
  /// <param name = "openXmlElement">The OpenXml element to convert. Should be a DX.StringValue containing a valid GUID string, or null.</param>
  /// <param name = "modelType">The target model type. Must be typeof(Guid) to perform the conversion.</param>
  /// <returns>A Guid object if the OpenXml element contains a valid GUID string and the model type is Guid; otherwise, null.</returns>
  private static object? ConvertGuidFromOpenXml(object? openXmlElement, Type modelType)
  {
    if (modelType == typeof(Guid))
    {
      if (openXmlElement is DX.StringValue stringValue)
      {
        if (Guid.TryParse(stringValue.Value, out var guid))
          return guid;
      }
      return SimpleValueConverter.ConvertFrom(openXmlElement, modelType);
    }
    return null;
  }

  /// <summary>
  /// Converts a <see cref = "Guid"/> object to an OpenXml-compatible value if the specified type is supported.
  /// </summary>
  /// <remarks>The method returns <see langword="null"/> if the input object is not a <see cref = "Guid"/> or if
  /// the specified OpenXml type is not supported. The string representation uses the "B" format and is converted to
  /// uppercase.</remarks>
  /// <param name = "modelObject">The object to convert. Must be a <see cref = "Guid"/> instance to perform the conversion; otherwise, no conversion
  /// is performed.</param>
  /// <param name = "openXmlType">The target OpenXml type to convert to. Currently, only <see cref = "DX.StringValue"/> is supported.</param>
  /// <returns>An instance of <see cref = "DX.StringValue"/> containing the uppercase, bracketed string representation of the <see 
  ///cref = "Guid"/> if conversion is successful; otherwise, <see langword="null"/>.</returns>
  private static object? ConvertToGuidOpenXml(object? modelObject, Type openXmlType)
  {
    if (modelObject is Guid guid)
    {
      if (openXmlType == typeof(DX.StringValue))
      {
        var text = guid.ToString("B").ToUpper();
        return new DX.StringValue(text);
      }
      return SimpleValueConverter.ConvertTo(modelObject, openXmlType);
    }
    return null;
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
  /// <param name = "propertyName">The name of the property that has changed. Cannot be null or empty.</param>
  public virtual void NotifyPropertyChanged(string propertyName)
  {
    UpdatePropertyData(propertyName);
    if (IsNotificationEnabled)
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }

  /// <summary>
  /// Updates data and raises a property changed notification for the specified property with old and new value.
  /// </summary>
  /// <remarks>Call this method to notify listeners that a property value has changed, typically when
  /// implementing the INotifyPropertyChanged interface in data-binding scenarios.</remarks>
  /// <param name = "propertyName">The name of the property that has changed. Cannot be null or empty.</param>
  /// <param name = "oldValue">Old value of the property</param>
  /// <param name = "newValue">New value of the property</param>
  public virtual void NotifyPropertyChanged(string propertyName, object? oldValue, object? newValue)
  {
    UpdatePropertyData(propertyName);
    if (IsNotificationEnabled)
      PropertyChanged?.Invoke(this, new PropertyValueChangedEventArgs(propertyName, oldValue, newValue));
  }

  /// <summary>
  /// Raises a property changed notification for the specified property.
  /// </summary>
  /// <remarks>Call this method to notify listeners that a property value has changed, typically when
  /// implementing the INotifyPropertyChanged interface in data-binding scenarios.</remarks>
  /// <param name = "propertyName">The name of the property that has changed. Cannot be null or empty.</param>
  public void OnPropertyChanged(string propertyName)
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }

  /// <summary>
  /// Raises a property changed notification for the specified property with old and new value.
  /// No update to OpenXml element is performed.
  /// </summary>
  /// <remarks>Call this method to notify listeners that a property value has changed, typically when
  /// implementing the INotifyPropertyChanged interface in data-binding scenarios.</remarks>
  /// <param name = "propertyName">The name of the property that has changed. Cannot be null or empty.</param>
  /// <param name = "oldValue">Old value of the property</param>
  /// <param name = "newValue">New value of the property</param>
  public void OnPropertyChanged(string propertyName, object? oldValue, object? newValue)
  {
    PropertyChanged?.Invoke(this, new PropertyValueChangedEventArgs(propertyName, oldValue, newValue));
  }

  /// <summary>
  /// Gets the first element of the specified OpenXmlType from OpenXmlCompositeElement and converts it to ModelType.
  /// </summary>
  /// <typeparam name="ModelType">Type of the output model value</typeparam>
  /// <typeparam name="OpenXmlType">Type of the OpenXml element to find.</typeparam>
  /// <param name="openXmlParentElement">Composite element to search for the specified OpenXmlType.</param>
  /// <returns>The first element of the specified OpenXmlType converted to ModelType, or null if not found.</returns>
  protected ModelType? GetElement<ModelType, OpenXmlType>(DX.OpenXmlCompositeElement? openXmlParentElement)
    where OpenXmlType : DX.OpenXmlElement
  {
    if (openXmlParentElement == null)
      return default;

    return OpenXmlModelConverter.ConvertFrom<ModelType, OpenXmlType>(openXmlParentElement.Elements<OpenXmlType>()
      .FirstOrDefault());
  }
  /// <summary>
  /// Gets or creates the first element of the specified OpenXmlType from OpenXmlCompositeElement and converts it to ModelType.
  /// </summary>
  /// <typeparam name="ModelType">Type of the output model value</typeparam>
  /// <typeparam name="OpenXmlType">Type of the OpenXml element to find.</typeparam>
  /// <param name="openXmlParentElement">Composite element to search for the specified OpenXmlType.</param>
  /// <returns>The element of the specified OpenXmlType converted to ModelType.</returns>
  protected ModelType GetOrCreateElement<ModelType, OpenXmlType>(DX.OpenXmlCompositeElement? openXmlParentElement)
    where ModelType : ModelElement<OpenXmlType>
    where OpenXmlType : DX.OpenXmlElement
  {
    var openXmlElement = openXmlParentElement?.Elements<OpenXmlType>().FirstOrDefault();
    if (openXmlElement == null)
    {
      openXmlElement = Activator.CreateInstance<OpenXmlType>();
      openXmlParentElement?.AppendChild(openXmlElement);
    }
    var modelValue = OpenXmlModelConverter.ConvertFrom<ModelType, OpenXmlType>(openXmlElement)!;
    if (modelValue is ModelElement modelElement)
      modelElement.Parent = this;
    if (modelValue is IUpdatable updatable)
      updatable.SetUpdatableObject(openXmlElement);
    return modelValue;
  }

  /// <summary>
  /// Convert a value of the OpenXmlElement property to ModelType.
  /// </summary>
  /// <typeparam name="ModelType">Type of the output model value</typeparam>
  /// <param name="openXmlValue">The OpenXml value to convert.</param>
  /// <returns>The converted model value, or null if the OpenXml value is null.</returns>
  protected ModelType? GetProperty<ModelType>(object? openXmlValue)
  {
    if (openXmlValue == null)
      return default;

    var modelValue = (ModelType?)OpenXmlModelConverter.ConvertFrom(openXmlValue, typeof(ModelType));
    if (modelValue is ModelElement modelElement)
      modelElement.Parent = this;
    if (modelValue is IUpdatable updatable)
      updatable.SetUpdatableObject(openXmlValue);
    return modelValue;
  }


  /// <summary>
  /// Updates the specified field with a new value and raises a property change notification if the value has changed.
  /// </summary>
  /// <remarks>This method is typically used in property setters to implement the INotifyPropertyChanged
  /// pattern. The property change notification is only raised if the field value actually changes.</remarks>
  /// <param name = "fieldValue">A reference to the field to be updated. The field will be set to <paramref name = "newValue"/> if its current value
  /// is not equal to <paramref name = "newValue"/>.</param>
  /// <param name = "newValue">The new value to assign to the field. If the value differs from the current field value, the field is updated and
  /// a property change notification is triggered.</param>
  /// <param name = "propertyName">The name of the property associated with the field. Used to identify which property has changed when raising the
  /// notification.</param>
  protected void UpdateField<FieldType>(ref FieldType? fieldValue, FieldType? newValue, string propertyName)
  {
    if (newValue is string stringValue && stringValue.Length == 0)
      newValue = default;
    if (!Equals(fieldValue, newValue))
    {
      var oldValue = fieldValue;
      if (fieldValue is IChildItem oldChild && oldChild.Parent == this)
        oldChild.Parent = null;
      DXPP.WordprocessingDocument? oldWordprocessingDocument = null;
      if (fieldValue is IWordprocessingDocumentAware oldWDAValue && oldWDAValue.WordprocessingDocument != null)
      {
        oldWordprocessingDocument = oldWDAValue.WordprocessingDocument;
        oldWDAValue.Detach();
      }
      else 
        oldWordprocessingDocument = (this as IWordprocessingDocumentAware)?.WordprocessingDocument;

      fieldValue = newValue;
      if (fieldValue is IChildItem newChild && newChild.Parent == null)
        newChild.Parent = this;
      if (!IsLoading && newValue is IWordprocessingDocumentAware newWDAValue && oldWordprocessingDocument != null)
        newWDAValue.AttachAndUpdate(oldWordprocessingDocument);
      if (newValue is INotifyCollectionChanged collection)
        collection.CollectionChanged += ChildCollectionChanged;
      if (newValue is INotifyPropertyChanged notificator)
        notificator.PropertyChanged += ChildPropertyChanged;
      if (newValue is INotificationSource source)
        source.PropertyName = propertyName;
      if (IsNotificationEnabled)
        NotifyPropertyChanged(propertyName, oldValue, newValue);

      if (!IsLoading)
        if (this is IWordprocessingDocumentAware wordprocessingDocumentAware)
        {
          var wordprocessingDocument = wordprocessingDocumentAware.WordprocessingDocument;
          if (wordprocessingDocument != null)
          {
            wordprocessingDocumentAware.AttachAndUpdate(wordprocessingDocument);
            var themePart = wordprocessingDocument.MainDocumentPart?.ThemePart;
          }
        }
    }

  }

  #region INotificationSource implementation

  /// <summary>
  /// Property name to be used when the object raise PropertyChanged event.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public string? PropertyName { get; set; }

  /// <summary>
  /// Flag to determine if notification is enabled when the object raise PropertyChanged event.
  /// It should be set to true when the object is created.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public bool IsNotificationEnabled
  {
    get => _IsNotificationEnabled ?? Parent is INotificationSource parentSource && parentSource.IsNotificationEnabled ||
      Collection is INotificationSource collectionSource && collectionSource.IsNotificationEnabled;
    set => _IsNotificationEnabled = value;
  }

  /// <summary>
  /// Helper field for IsNotificationEnabled property. It is set to true when the object is created,
  /// and can disable notification for this object and its children.
  /// </summary>
  protected bool? _IsNotificationEnabled;

  #endregion

  /// <summary>
  /// Invoked on child item property change to raise PropertyChanged event on this model.
  /// </summary>
  /// <param name = "sender">Child item that raised PropertyChanged event.</param>
  /// <param name = "args">Arguments of the event (ignored)</param>
  private void ChildPropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (sender is INotificationSource source)
      if (source.PropertyName is not null)
        NotifyPropertyChanged(source.PropertyName);
  }

  /// <summary>
  /// Invoked on child collection changed to raise PropertyChanged event on this model.
  /// </summary>
  /// <param name = "sender">Collection that raised CollectionChanged event.</param>
  /// <param name = "args">Arguments of the event (ignored)</param>
  private void ChildCollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (sender is INotificationSource source)
      if (source.PropertyName is not null)
        NotifyPropertyChanged(source.PropertyName);
  }

  /// <summary>
  /// Determines whether the current ModelElement is equal to another ModelElement instance.
  /// </summary>
  /// <param name = "other">The ModelElement to compare with the current instance. Can be null.</param>
  /// <returns>true if the specified ModelElement is equal to the current instance; otherwise, false.</returns>
  public bool Equals(ModelElement? other)
  {
    if (other is null)
      return false;
    if (ReferenceEquals(this, other))
      return true;

    return DeepComparer.Equals(this, other);
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current ModelElement instance.
  /// </summary>
  /// <remarks>Equality is determined by comparing the runtime type and the values of the ModelElement. This
  /// method overrides Object.Equals(Object).</remarks>
  /// <param name = "obj">The object to compare with the current ModelElement instance.</param>
  /// <returns>true if the specified object is a ModelElement and is equal to the current instance; otherwise, false.</returns>
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
  public override bool Equals(object? obj)
  {
    if (obj is null)
      return false;
    if (ReferenceEquals(this, obj))
      return true;
    if (obj.GetType() != GetType())
      return false;

    return DeepComparer.Equals(this.GetType(), this, obj);
  }

  /// <summary>
  /// Determines whether the current ModelElement should be serialized. This method can be overridden in derived classes to implement custom serialization logic.
  /// </summary>
  /// <returns><see langword="true"/>In this implementation, always return true</returns>
  public virtual bool ShouldSerialize()
  {
    return true;
  }

  /// <summary>
  /// Determines whether the specified object should be serialized based on its type and state.   
  /// </summary>
  /// <remarks>If the provided object implements the ISerializationEnabling interface, this method delegates
  /// the decision to the object's ShouldSerialize method. Otherwise, it returns true, indicating that the object
  /// should be serialized by default.</remarks>
  /// <param name="value">The object to evaluate for serialization. If the object implements the ISerializationEnabling interface, its
  /// ShouldSerialize method is used to determine serializability.</param>
  /// <returns>true if the object should be serialized; otherwise, false.</returns>
  public bool ShouldSerialize(object value)
  {
    if (value is ISerializationEnabling serializationEnabling)
      return serializationEnabling.ShouldSerialize();

    return true;
  }

  /// <summary>
  /// Gets a dictionary of known properties for the current model element type, where the keys are property names
  /// and the values are PropertyModel instances containing metadata about each property.
  /// </summary>
  /// <returns></returns>
  /// <exception cref = "NotImplementedException"></exception>
  public KnownProperties GetKnownProperties()
  {
    if (_knownProperties == null)
    {
      var modelType = this.GetType();
      var knownProperties =
        modelType.GetProperty("KnownProperties", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as
          KnownProperties;
      if (knownProperties == null)
        knownProperties = new KnownProperties(modelType);
      _knownProperties = new KnownProperties();
      foreach (var kvp in knownProperties)
      {
        var prop = kvp.Value;
        var modelProp = (PropertyModel)prop.Clone()!;
        modelProp.Component = this;
        _knownProperties.Add(modelProp);
      }
    }
    return _knownProperties;
  }

  private KnownProperties? _knownProperties;

  /// <summary>
  /// Loads data into the current model element from an external source. This method is intended to be overridden in derived classes to implement specific data loading logic. The base implementation throws a NotImplementedException, indicating that derived classes must provide their own implementation.
  /// </summary>
  /// <returns>True if the data was successfully loaded; otherwise, false.</returns>
  /// <exception cref="NotImplementedException"></exception>
  public virtual bool LoadData()
  {
    var updatedObject = GetUpdatableObject();
    if (updatedObject != null)
    {
      LoadData(updatedObject);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Updates the current model element's data in an external source. This method is intended to be overridden in derived classes to implement specific data updating logic. The base implementation throws a NotImplementedException, indicating that derived classes must provide their own implementation.
  /// </summary>
  /// <returns>True if the data was successfully updated; otherwise, false.</returns>
  /// <exception cref="NotImplementedException"></exception>
  public virtual bool UpdateData()
  {
    var updatedObject = GetUpdatableObject();
    if (updatedObject != null)
    {
      UpdateData(updatedObject);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Populates the current model element's properties with values from the specified Open XML element.
  /// </summary>
  /// <remarks>This method maps properties from the provided Open XML element to the corresponding properties of
  /// the model element. Only writable properties are updated. Override this method in a derived class to customize the
  /// data loading behavior.</remarks>
  /// <param name = "openXmlObject">The Open XML element or other object containing the data to load into the model element.
  /// Must be compatible with the current model element type.</param>
  public virtual void LoadData(object openXmlObject)
  {
    SetLoading(true);
    OpenXmlModelConverter.LoadData(this, openXmlObject);
    SetLoading(false);
  }

  /// <summary>
  /// Updates the specified Open XML element with the current values of this model's public properties.
  /// </summary>
  /// <remarks>This method maps each public property of the model to a corresponding property on the Open XML
  /// element and sets its value. Derived classes can override this method to customize the update behavior. The method
  /// does not perform validation on the Open XML element; callers should ensure it is compatible with the model
  /// type.</remarks>
  /// <param name = "openXmlObject">The Open XML element or other object to update with property values from this model.
  /// Must not be null.</param>
  public virtual void UpdateData(object openXmlObject)
  {
    var openXmlType = this.GetType().GetCustomAttribute<OpenXmlTypeAttribute>()?.Type ?? openXmlObject.GetType();
    OpenXmlModelConverter.UpdateData(this, openXmlObject, openXmlType);
  }

  /// <summary>
  /// Updates the value of the specified property in the underlying Open XML element, if it is available.
  /// </summary>
  /// <remarks>If the underlying Open XML element is not available, no update is performed. This method does not
  /// throw an exception if the property or element is missing.</remarks>
  /// <param name = "propertyName">The name of the property to update. This value cannot be null.</param>
  public virtual void UpdatePropertyData(string propertyName)
  {
    var updatableObject = GetUpdatableObject();
    if (updatableObject == null)
      return;

    var modelProperty = this.GetType().GetProperty(propertyName);
    if (modelProperty == null)
      return;

    var openXmlType = updatableObject.GetType()!;
    var openXmlProperty = OpenXmlPropertyMap.GetOpenXmlProperty(modelProperty, openXmlType);
    if (openXmlProperty == null)
      return;

    OpenXmlModelConverter.UpdateOpenXmlProperty(this, modelProperty, updatableObject, openXmlProperty);
  }

  /// <summary>
  /// Gets the underlying Open XML element that can be updated by this model element. This method returns the object that represents the data source for this model, which may be an OpenXmlElement or another type of object. If no updatable element is associated with this model, the method returns null.
  /// </summary>
  /// <returns></returns>
  public virtual object? GetUpdatableObject() => _UpdatableObject;

  /// <summary>
  /// Sets the underlying Open XML element that can be updated by this model element. This method allows the model to be associated with a specific data source, which may be an OpenXmlElement or another type of object. If null is passed, the model will not have an updatable element.
  /// </summary>
  /// <param name="element">The Open XML element or other object to associate with this model element. Can be null to clear the current association.</param>
  public virtual void SetUpdatableObject(object? element) => _UpdatableObject = element;

  /// <summary>
  /// Gets or sets the underlying Open XML element that can be updated by this model element.
  /// </summary>
  private object? _UpdatableObject;

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
  public object? Collection
  {
    [DebuggerStepThrough]
    get => _Collection;
  }

  /// <summary>
  /// Sets the collection object to be used by the instance.
  /// </summary>
  /// <param name = "collection">The collection object to assign. Can be null to clear the current collection.</param>
  public void SetCollection(object? collection)
  {
    _Collection = collection;
  }

  private object? _Collection;

  /// <summary>
  /// Gets a value indicating whether the object has been modified since it was last saved or loaded.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public bool IsModified => _IsModified;

  private bool _IsModified;

  /// <summary>
  /// Sets the IsModified flag to be used by the instance.
  /// </summary>
  /// <param name = "isModified">The isModified value to set.</param>
  public void SetIsModified(bool isModified)
  {
    if (IsLoading)
      return;

    if (_IsModified != isModified)
    {
      _IsModified = isModified;
      if (IsModified)
      {
        if (Parent is IModifiable modifiableParent)
          modifiableParent.SetIsModified(IsModified);
        else if (Collection is IModifiable modifiableCollection)
          modifiableCollection.SetIsModified(IsModified);
      }
      else
      {
        foreach (var prop in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
          try
          {
            if (prop.GetIndexParameters().Length == 0)
              if (prop.GetValue(this) is IModifiable modifiableChild)
                modifiableChild.SetIsModified(IsModified);
          }
          catch (Exception ex)
          {
            Debug.WriteLine(
              $"Error setting IsModified for property '{prop.Name}' of type '{this.GetType().Name}': {ex.Message}");
          }
        }
      }
      NotifyPropertyChanged(nameof(IsModified));
    }
  }

  /// <summary>
  /// Gets a value indicating whether the object is currently loaded.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public bool IsLoading
  {
    get => _IsLoading ?? (Parent is ILoadable loadableParent && loadableParent.IsLoading);
  }
  private bool? _IsLoading;

  /// <summary>
  /// Changes the loading state of the component. When set to true, it indicates that the component is currently loading, and any modifications made during this time should not trigger change notifications or mark the component as modified. When set to false, it indicates that loading is complete, and subsequent changes will be tracked normally.
  /// </summary>
  /// <param name="isLoading"></param>
  public void SetLoading(bool isLoading)
  {
    _IsLoading = isLoading == false ? null : isLoading;
  }

  /// <summary>
  /// Checks if all public properties of the current model element are null or empty (for strings and collections).
  /// </summary>
  /// <returns>True if all public properties are null or empty; otherwise, false.</returns>
  public virtual bool IsEmpty()
  {
    foreach (var prop in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
    {
      if (prop.GetIndexParameters().Length == 0 && prop.CanWrite &&
          prop.GetCustomAttribute<NotMappedAttribute>() == null)
      {
        var value = prop.GetValue(this);
        if (value != null)
        {
          if (value is string strValue)
          {
            if (!string.IsNullOrEmpty(strValue))
              return false;
          }
          else if (value is IEmptyCheckable emptyCheckValue)
          {
            if (!emptyCheckValue.IsEmpty())
              return false;
          }
          else if (value is IEnumerable enumerableValue)
          {
            foreach (var item in enumerableValue)
            {
              if (item != null)
                return false;
            }
          }
          else
            return false;
        }
      }
    }
    return true;
  }
}