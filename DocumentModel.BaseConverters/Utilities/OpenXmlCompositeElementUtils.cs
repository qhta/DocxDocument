namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlCompositeElement object.
/// </summary>
public static class OpenXmlCompositeElementUtils
{
  #region Twips get/set methods
  public static Twips? GetTwipsVal<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        if (_element is DXW.TwipsMeasureType twipsMeasure)
        {
          var str = twipsMeasure.Val?.Value;
          if (str != null)
            return new Twips(str);
        }
        else
        if (_element is DXW.NonNegativeShortType nonNegativeShort)
        {
          var n = nonNegativeShort.Val?.Value;
          if (n != null)
            return new Twips((short)n);
        }
        else
        if (_element is DXM.TwipsMeasureType twipsMeasureM)
        {
          var val = twipsMeasureM.Val?.Value;
          if (val != null)
            return new Twips((uint)val);
        }
        else
          throw new InvalidDataException($"Unsupported twips conversion from type {_element.GetType()}");
      }
    }
    return null;
  }

  public static void SetTwipsVal<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, Twips? value) where ElementType : DX.OpenXmlLeafElement, new()
  {
    if (value is not null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element == null)
      {
        _element = new ElementType();
        openXmlElement.AppendChild(_element);
      }
      if (_element is DXW.TwipsMeasureType twipsMeasure)
        twipsMeasure.Val = (string)value;
      else
      if (_element is DXW.NonNegativeShortType nonNegativeShort)
        nonNegativeShort.Val = (short)value;
      else
      if (_element is DXM.TwipsMeasureType twipsMeasureM)
        twipsMeasureM.Val = new DX.UInt32Value((uint)value);
      else
        throw new InvalidDataException($"Unsupported twips conversion to type {_element.GetType()}");
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  #endregion

  #region Object get/set methods
  public static ObjectType? GetObject<ObjectType, ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ObjectType : class
    where ElementType : DX.OpenXmlElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var constructor = typeof(ObjectType).GetConstructor(new Type[] { typeof(DX.OpenXmlElement) });
        Debug.Assert(constructor != null, $"Type {typeof(ObjectType)} must have constructor with OpenXmlElement parameter");
        return (ObjectType)constructor.Invoke(new object[] { _element });
      }
    }
    return null;
  }

  public static void SetObject<ObjectType, ElementType>(this DX.OpenXmlCompositeElement openXmlElement, ObjectType? value) where ObjectType : class, IOpenXmlElementMappedObject
  where ElementType : DX.OpenXmlElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var _newElement = value.GetElement<ElementType>();
        if (_element != _newElement)
        {
          _element.Remove();
          openXmlElement.AppendChild(_newElement);
        }
      }
      else
        openXmlElement.AppendChild(value.GetElement<ElementType>());
    }
    else
    {
      var element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (element != null)
        element.Remove();
    }
  }

  #endregion

  public static void AddChildElement(this DX.OpenXmlCompositeElement openXmlElement, DX.OpenXmlElement childElement)
  {
    if (childElement.Parent != null)
      childElement.Remove();
    openXmlElement.AppendChild(childElement);
  }

}
