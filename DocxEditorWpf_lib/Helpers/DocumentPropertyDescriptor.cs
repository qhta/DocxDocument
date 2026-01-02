namespace DocxEditor.Helpers;

public class DocumentPropertyDescriptor : PropertyDescriptor
{
  private readonly DocumentPropertiesProvider propertiesProvider;

  #region Constructors

  public DocumentPropertyDescriptor(DocumentPropertiesProvider propertiesProvider,
    string propertyName,
    string propertyDisplayName,
    Type propertyType,
    Attribute[] propertyAttributes)
    : base(propertyName, propertyAttributes)
  {
    this.propertiesProvider = propertiesProvider;
    PropertyType = propertyType;
    DisplayName = propertyDisplayName;
  }

  #endregion

  #region Properties

  public override Type ComponentType => typeof(DocumentPropertiesProvider);

  public override string DisplayName { get; }

  public override bool IsReadOnly => false;

  public override Type PropertyType { get; }

  #endregion

  #region Override members

  public override bool CanResetValue(object component) => true;

  public override object? GetValue(object? component)
  {
    var model = propertiesProvider.Models[Name];
    return model.GetValue(model.Component);
  }

  public override void ResetValue(object component)
  {
  }

  public override void SetValue(object? component, object? value)
  {
    var model = propertiesProvider.Models[Name];
    model.SetValue(model.Component, value);
  }

  public override bool ShouldSerializeValue(object component)
  {
    return false;
  }

  #endregion
}