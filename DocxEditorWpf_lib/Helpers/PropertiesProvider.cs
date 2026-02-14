namespace DocxEditor.Helpers;

/// <summary>
/// Provides properties of the component to be displayed in the property grid.
/// It must implement ICustomTypeDescriptor to allow dynamic properties recognition by the property grid,
/// which is necessary because the properties of the component are not known at compile time
/// and can vary depending on the component's content and structure.
/// </summary>
public class PropertiesProvider: ViewModel, ICustomTypeDescriptor
{

  /// <summary>
  /// Initializing constructor
  /// </summary>
  /// <param name="component">Model component that is the source of properties.</param>
  public PropertiesProvider(object component)
  {
    if (component is IPropertiesProvider propertiesProvider)
      KnownProperties = propertiesProvider.GetKnownProperties();
    else
      throw new InvalidOperationException($"{component} must implement IPropertiesProvider");
  }

  //private IDictionary<string, PropertyModel> _models = new Dictionary<string, PropertyModel>();
  private IDictionary<string, string> displayNames = new Dictionary<string, string>();

  private KnownProperties KnownProperties { get; }

  /// <summary>
  /// Gets the models representing the properties of the document.
  /// </summary>
  public IEnumerable<PropertyModel> Models => KnownProperties.Values;

  /// <summary>
  /// Dictionary of display names for the properties, keyed by property name.
  /// If a property does not have a display name in this dictionary, its property name will be used as the display name.
  /// </summary>
  public IDictionary<string, string> DisplayNames
  {
    get => displayNames;
    set
    {
      displayNames = value;
      NotifyPropertyChanged(nameof(DisplayNames));
    }
  }

  /// <summary>
  /// Gets the display name for a given property model, which is used to show the property in the property grid.
  /// </summary>
  /// <param name="model"></param>
  /// <returns></returns>
  public string GetDisplayName(PropertyModel model)
  {
    displayNames.TryGetValue(model.Name, out var displayName);
    return displayName ?? model.DisplayName;
  }

  #region ICustomTypeDescriptor Members

  /// <summary>
  /// Gets a collection of properties for the current instance.
  /// </summary>
  /// <remarks>
  /// It is the most important method of the ICustomTypeDescriptor interface in this context,
  /// as it provides the dynamic properties of the document to be displayed in the property grid.
  /// </remarks>
  public PropertyDescriptorCollection GetProperties()
  {
    var propertyDetails = Models.Select(model => new ModelPropertyDescriptor(this, model));
    return new PropertyDescriptorCollection(propertyDetails.ToArray<PropertyDescriptor>());
  }

  /// <summary>
  /// Returns a collection of attributes for the current instance.
  /// </summary>
  public AttributeCollection GetAttributes()
  {
    return TypeDescriptor.GetAttributes(this, true);
  }

  /// <summary>
  /// Retrieves the class name of the current instance as recognized by the type descriptor system.
  /// </summary>
  /// <remarks>
  /// Not used in this context, but required by the ICustomTypeDescriptor interface.
  /// </remarks>
  public string? GetClassName()
  {
    return TypeDescriptor.GetClassName(this, true);
  }

  /// <summary>
  /// Gets the name of the component as recognized by the type descriptor system.
  /// </summary>
  /// <remarks>
  /// Not used in this context, but required by the ICustomTypeDescriptor interface.
  /// </remarks>

  public string? GetComponentName()
  {
    return TypeDescriptor.GetComponentName(this, true);
  }

  /// <summary>
  /// Gets a type converter for the current instance, which can be used to convert the instance to and from other types.
  /// </summary>
  /// <remarks>
  /// Not used in this context, but required by the ICustomTypeDescriptor interface.
  /// </remarks>
  public TypeConverter GetConverter()
  {
    return TypeDescriptor.GetConverter(this, true);
  }

  /// <summary>
  /// Gets the default event for the current instance,
  /// which is the event that is considered the most important or commonly used event for the component.
  /// </summary>
  /// <remarks>
  /// Not used in this context, but required by the ICustomTypeDescriptor interface.
  /// </remarks>
  public EventDescriptor? GetDefaultEvent()
  {
    return TypeDescriptor.GetDefaultEvent(this, true);
  }

  /// <summary>
  /// Gets the default property for the current instance,
  /// </summary>
  /// <remarks>
  /// Not used in this context, but required by the ICustomTypeDescriptor interface.
  /// </remarks>
  public PropertyDescriptor? GetDefaultProperty()
  {
    return TypeDescriptor.GetDefaultProperty(this, true);
  }

  /// <summary>
  /// Gets an editor of the specified type for the current instance,
  /// which can be used to provide a user interface for editing the instance.
  /// </summary>
  /// <remarks>
  /// Not used in this context, but required by the ICustomTypeDescriptor interface.
  /// </remarks>
  public object? GetEditor(Type editorBaseType)
  {
    return TypeDescriptor.GetEditor(this, editorBaseType, true);
  }

  /// <summary>
  /// Gets a collection of events for the current instance,
  /// which can be used to display the events in a property grid or other user interface.
  /// </summary>
  /// <remarks>
  /// Not used in this context, but required by the ICustomTypeDescriptor interface.
  /// </remarks>
  public EventDescriptorCollection GetEvents()
  {
    return TypeDescriptor.GetEvents(this, true);
  }

  /// <summary>
  /// Gets a collection of events for the current instance that match the specified attributes,
  /// </summary>
  /// <remarks>
  /// Not used in this context, but required by the ICustomTypeDescriptor interface.
  /// </remarks>
  public EventDescriptorCollection GetEvents(Attribute[]? attributes)
  {
    return TypeDescriptor.GetEvents(this, attributes, true);
  }

  /// <summary>
  /// Gets a collection of properties for the current instance that match the specified attributes,
  /// </summary>
  /// <remarks>
  /// Not used in this context, but required by the ICustomTypeDescriptor interface.
  /// </remarks>
  public PropertyDescriptorCollection GetProperties(Attribute[]? attributes)
  {
    // ReSharper disable once CollectionNeverUpdated.Local
    var propList = new ArrayList();
    var propCollection = (PropertyDescriptor[])propList.ToArray(typeof(PropertyDescriptor));
    return new PropertyDescriptorCollection(propCollection);
  }

  /// <summary>
  /// Gets the owner of the specified property descriptor, which is the object that the property belongs to.
  /// </summary>
  /// <remarks>
  /// Not used in this context, but required by the ICustomTypeDescriptor interface.
  /// </remarks>
  public object GetPropertyOwner(PropertyDescriptor? pd)
  {
    return (pd as PropertyModel)?.Component ?? this;
  }

  #endregion

}