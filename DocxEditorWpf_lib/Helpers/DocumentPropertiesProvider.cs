namespace DocxEditor.Helpers
{
  public class DocumentPropertiesProvider : ViewModel, ICustomTypeDescriptor
  {
    private IDictionary<string, PropertyModel> _models = new Dictionary<string, PropertyModel>();
    private IDictionary<string, string> displayNames = new Dictionary<string, string>();

    #region Properties

    public IDictionary<string, PropertyModel> Models
    {
      get => _models;
      set
      {
        _models = value;
        NotifyPropertyChanged(nameof(Models));
      }
    }

    public IDictionary<string, string> DisplayNames
    {
      get => displayNames;
      set
      {
        displayNames = value;
        NotifyPropertyChanged(nameof(DisplayNames));
      }
    }

    #endregion

    #region ICustomTypeDescriptor Members

    public AttributeCollection GetAttributes()
    {
      return TypeDescriptor.GetAttributes(this, true);
    }

    public string? GetClassName()
    {
      return TypeDescriptor.GetClassName(this, true);
    }

    public string? GetComponentName()
    {
      return TypeDescriptor.GetComponentName(this, true);
    }

    public TypeConverter GetConverter()
    {
      return TypeDescriptor.GetConverter(this, true);
    }

    public EventDescriptor? GetDefaultEvent()
    {
      return TypeDescriptor.GetDefaultEvent(this, true);
    }

    public PropertyDescriptor? GetDefaultProperty()
    {
      return TypeDescriptor.GetDefaultProperty(this, true);
    }

    public object? GetEditor(Type editorBaseType)
    {
      return TypeDescriptor.GetEditor(this, editorBaseType, true);
    }

    public EventDescriptorCollection GetEvents()
    {
      return TypeDescriptor.GetEvents(this, true);
    }

    public EventDescriptorCollection GetEvents(Attribute[]? attributes)
    {
      return TypeDescriptor.GetEvents(this, attributes, true);
    }

    public PropertyDescriptorCollection GetProperties()
    {
      var propertyDetails = Models.Select(element =>
      {
        displayNames.TryGetValue(element.Key, out var displayName);
        displayName = displayName ?? element.Key;
        return new DocumentPropertyDescriptor(this,
                                                  element.Key,
                                                  displayName,
                                                  element.Value.PropertyType,
                                                  []);
      });
      return new PropertyDescriptorCollection(propertyDetails.ToArray<PropertyDescriptor>());
    }

    public PropertyDescriptorCollection GetProperties(Attribute[]? attributes)
    {
      // ReSharper disable once CollectionNeverUpdated.Local
      var propList = new ArrayList();
      var propCollection = (PropertyDescriptor[])propList.ToArray(typeof(PropertyDescriptor));
      return new PropertyDescriptorCollection(propCollection);
    }

    public object GetPropertyOwner(PropertyDescriptor? pd)
    {
      return this;
    }

    #endregion
  }


}