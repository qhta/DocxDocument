#pragma warning disable CS0659  
namespace DocumentModel;

/// <summary>
/// Base class for all model elements, providing property change notification support.
/// </summary>
public abstract class ModelElement : INotifyPropertyChanged, IEquatable<ModelElement>, IChildItem, ICollectionItem,
  IModifiable, INotificationSource, ILoadable, IPropertiesProvider
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
  /// Passes the IsModified up to the parent IModifiable object.
  /// </summary>
  /// <param name="sender">Sender object that raised the event.</param>
  /// <param name="args">Event arguments containing the property name.</param>
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
    OpenXmlModelConverter.ConvertFromOpenDelegates[typeof(Guid)] = ConvertGuidFromOpenXml;
    OpenXmlModelConverter.ConvertToOpenDelegates[typeof(Guid)] = ConvertToGuidOpenXml;
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
  /// Occurs when a property value changes. Can be subscribed to by listeners to receive notifications of property changes.
  /// </summary>
  public event PropertyChangedEventHandler? PropertyChanged;

  /// <summary>
  /// Updates data and raises a property changed notification for the specified property.
  /// </summary>
  /// <remarks>Call this method to notify listeners that a property value has changed, typically when
  /// implementing the INotifyPropertyChanged interface in data-binding scenarios.</remarks>
  /// <param name="propertyName">The name of the property that has changed. Cannot be null or empty.</param>
  public virtual void NotifyPropertyChanged(string propertyName)
  {
    if (propertyName == "IsModified")
      return;
    UpdatePropertyData(propertyName);
    if (IsNotificationEnabled)
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

    if (value is string stringValue && stringValue.Length == 0)
      value = default;
    if (!Equals(field, value))
    {
      if (field is IChildItem oldChild && oldChild.Parent == this)
        oldChild.SetParent(null);
      if (field is IWordprocessingDocumentAware oldValue)
        oldValue.Detach();
      if (value is IWordprocessingDocumentAware newValue
          && this is IWordprocessingDocumentAware thisElement && thisElement.WordprocessingDocument != null)
        newValue.AttachAndUpdate(thisElement.WordprocessingDocument);
      else if (value is IUpdatable updatableValue)
        updatableValue.UpdateData();
      field = value;
      if (field is IChildItem newChild && newChild.Parent == null)
        newChild.SetParent(this);
      if (value is INotifyCollectionChanged collection) collection.CollectionChanged += ChildCollectionChanged;
      if (value is INotifyPropertyChanged notificator) notificator.PropertyChanged += ChildPropertyChanged;
      if (value is INotificationSource source) source.SetPropertyName(propertyName);
      if (IsNotificationEnabled)
        NotifyPropertyChanged(propertyName);
    }
    else if (field is IWordprocessingDocumentAware updatedValue)
    {
      var wordprocessingDocument = updatedValue.WordprocessingDocument;
      if (wordprocessingDocument != null)
        updatedValue.AttachAndUpdate(wordprocessingDocument);
    }
  }


  #region INotificationSource implementation
  /// <summary>
  /// Property name to be used when the object raise PropertyChanged event.
  /// </summary>
  public string? PropertyName => _PropertyName;

  private string? _PropertyName;

  /// <summary>
  /// Sets the property name.
  /// </summary>
  /// <param name="propertyName">Property name to set (null erases property name)</param>

  public void SetPropertyName(string? propertyName) => _PropertyName = propertyName;

  /// <summary>
  /// Flag to determine if notification is enabled when the object raise PropertyChanged event.
  /// It should be set to true when the object is created.
  /// </summary>
  public bool IsNotificationEnabled => _IsNotificationEnabled;

  private bool _IsNotificationEnabled;


  /// <summary>
  /// Sets the IsNotification flag to be used by the instance.
  /// Flag is set in this instance and child items.
  /// </summary>
  /// <param name="enabled">The enabled value to set.</param>
  public void SetNotificationEnabled(bool enabled)
  {
    Debug.WriteLine($"{this}.SetIsNotificationEnabled({enabled})");
    _IsNotificationEnabled = enabled;
    foreach (var prop in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
    {
      try
      {
        if (prop.CanWrite && prop.GetIndexParameters().Length == 0)
          if (prop.GetValue(this) is INotificationSource notificationSource)
            notificationSource.SetNotificationEnabled(enabled);

      }
      catch (Exception ex)
      {
        Debug.WriteLine($"Error setting IsNotificationEnabled for property '{prop.Name}' of type '{this.GetType().Name}': {ex.Message}");
      }
    }
  }

  #endregion

  /// <summary>
  /// Invoked on child item property change to raise PropertyChanged event on this model.
  /// </summary>
  /// <param name="sender">Child item that raised PropertyChanged event.</param>
  /// <param name="args">Arguments of the event (ignored)</param>
  private void ChildPropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (sender is INotificationSource source)
      if (source.PropertyName is not null)
        NotifyPropertyChanged(source.PropertyName);
  }

  /// <summary>
  /// Invoked on child collection changed to raise PropertyChanged event on this model.
  /// </summary>
  /// <param name="sender">Collection that raised CollectionChanged event.</param>
  /// <param name="args">Arguments of the event (ignored)</param>
  private void ChildCollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (sender is INotificationSource source)
      if (source.PropertyName is not null)
        NotifyPropertyChanged(source.PropertyName);
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
  /// Gets a dictionary of known properties for the current model element type, where the keys are property names
  /// and the values are PropertyModel instances containing metadata about each property.
  /// </summary>
  /// <returns></returns>
  /// <exception cref="NotImplementedException"></exception>
  public KnownProperties GetKnownProperties()
  {
    if (_knownProperties == null)
    {

      var modelType = this.GetType();
      var knownProperties =
        modelType.GetProperty("KnownProperties", BindingFlags.Public | BindingFlags.Static)?
            .GetValue(null) as KnownProperties;
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
  /// Populates the current model element's properties with values from the specified Open XML element.
  /// </summary>
  /// <remarks>This method maps properties from the provided Open XML element to the corresponding properties of
  /// the model element. Only writable properties are updated. Override this method in a derived class to customize the
  /// data loading behavior.</remarks>
  /// <param name="openXmlObject">The Open XML element or other object containing the data to load into the model element.
  /// Must be compatible with the current model element type.</param>
  public virtual void LoadData(object openXmlObject)
  {
    SetIsLoaded(true);
    OpenXmlModelConverter.LoadData(this, openXmlObject, this.GetType());
    SetIsLoaded(false);
  }

  /// <summary>
  /// Updates the specified Open XML element with the current values of this model's public properties.
  /// </summary>
  /// <remarks>This method maps each public property of the model to a corresponding property on the Open XML
  /// element and sets its value. Derived classes can override this method to customize the update behavior. The method
  /// does not perform validation on the Open XML element; callers should ensure it is compatible with the model
  /// type.</remarks>
  /// <param name="openXmlObject">The Open XML element or other object to update with property values from this model.
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
  /// <param name="propertyName">The name of the property to update. This value cannot be null.</param>
  public virtual void UpdatePropertyData(string propertyName)
  {
    var updatableElement = GetUpdatableElement();
    if (updatableElement == null)
      return;
    var modelProperty = this.GetType().GetProperty(propertyName);
    if (modelProperty == null) return;
    var openXmlType = updatableElement.GetType()!;
    var openXmlProperty = OpenXmlPropertyMap.GetOpenXmlPropertyForModelProperty(modelProperty, openXmlType);
    if (openXmlProperty == null) return;
    OpenXmlModelConverter.UpdateOpenXmlProperty(this, modelProperty, updatableElement, openXmlProperty);
  }

  /// <summary>
  /// Retrieves the Open XML element that can be updated by the derived class.  
  /// </summary>
  /// <remarks>Derived classes should override this method to return the Open XML element that supports
  /// modification. The returned object is typically used to apply changes to the document structure or
  /// content.</remarks>
  /// <returns>An object representing the updatable Open XML element. The specific type and structure depend on the
  /// implementation in the derived class.</returns>
  public virtual object? GetUpdatableElement() => null;

  /// <summary>
  /// Parent object that contains this item.
  /// </summary>
  public object? Parent
  {
    [DebuggerStepThrough]
    get => _Parent;
  }

  private object? _Parent;

  /// <summary>
  /// Sets the parent object to be used by the instance.
  /// </summary>
  /// <param name="parent">The parent object to assign. Can be null to clear the current parent.</param>
  public void SetParent(object? parent)
  {
    _Parent = parent;
  }


  /// <summary>
  /// Optional collection that contains this item.
  /// </summary>
  public ICollection? Collection
  {
    [DebuggerStepThrough]
    get => _Collection;
  }

  private ICollection? _Collection;

  /// <summary>
  /// Sets the collection object to be used by the instance.
  /// </summary>
  /// <param name="collection">The collection object to assign. Can be null to clear the current collection.</param>
  public void SetCollection(ICollection? collection)
  {
    _Collection = collection;
  }

  /// <summary>
  /// Gets a value indicating whether the object has been modified since it was last saved or loaded.
  /// </summary>
  public bool IsModified => _IsModified;

  private bool _IsModified;

  /// <summary>
  /// Sets the IsModified flag to be used by the instance.
  /// </summary>
  /// <param name="isModified">The isModified value to set.</param>
  public void SetIsModified(bool isModified)
  {
    if (IsLoaded)
      return;
    if (_IsModified != isModified)
    {
      Debug.WriteLine($"{this}.SetIsModified({isModified})");
      if (isModified && this is HeadingPairs)
        Debug.Assert(true);
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
            Debug.WriteLine($"Error setting IsModified for property '{prop.Name}' of type '{this.GetType().Name}': {ex.Message}");
          }
        }
      }
      if (this is DMW.Document) Debug.Assert(true);
      NotifyPropertyChanged(nameof(IsModified));
    }
  }


  /// <summary>
  /// Gets a value indicating whether the object is currently loaded.
  /// </summary>
  public bool IsLoaded => _IsLoaded;

  private bool _IsLoaded;

  /// <summary>
  /// Sets the IsLoaded flag to be used by the instance.
  /// </summary>
  /// <param name="isLoaded">The isLoaded value to set.</param>
  public void SetIsLoaded(bool isLoaded)
  {
    _IsLoaded = isLoaded;
  }

}