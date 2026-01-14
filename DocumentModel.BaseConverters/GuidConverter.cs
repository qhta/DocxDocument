namespace DocumentModel.OpenXml;

/// <summary>
///   Defines a Guid converter from OpenXml. 
/// </summary>
public static class GuidConverter
{
  #region Guid get/set methods

  /// <summary>
  /// Retrieves a Guid value from a child element within an OpenXmlCompositeElement.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <returns>The Guid value, or null if not found.</returns>
  public static Guid? GetGuidVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
        var val = valProperty.GetValue(_element);
        if (val != null)
        {
          var valType = val.GetType();
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value is string str)
          {
            return new Guid(str);
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets a Guid value on a child element within an OpenXmlCompositeElement.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The Guid value to set. If null, the child element is removed.</param>
  /// <exception cref="InvalidOperationException">Thrown if the child element's "Val" property is not of type StringValue.</exception>
  public static void SetGuidVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, Guid? value) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(OpenXmlElementType).GetConstructor(new Type[0]);
        Debug.Assert(constructor != null, $"Type {typeof(OpenXmlElementType)} must have constructor with no parameters");
        _element = (OpenXmlElementType)constructor.Invoke(new object[0]);
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      if (valType == typeof(DX.StringValue))
        valProperty.SetValue(_element, new DX.StringValue(value.ToString()));
      else
        throw new InvalidOperationException($"\"Value\" property of type {valType} unsupported");
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion

}