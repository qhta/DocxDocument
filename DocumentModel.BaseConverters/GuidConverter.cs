namespace DocumentModel.OpenXml;

/// <summary>
///   Defines a Guid converter from OpenXml. 
/// </summary>
public static class GuidConverter
{
  #region Guid get/set methods

  /// <summary>
  /// Gets a Guid value from OpenXmlCompositeElement containing OpenXmlElementType element with a "Val" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
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
  /// Sets the Guid value in OpenXmlCompositeElement containing OpenXmlElementType element with a "Val" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  /// <exception cref="InvalidOperationException"></exception>
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