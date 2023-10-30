using DocumentFormat.OpenXml.Math;

namespace DocumentModel.Wordprocessing;
partial class DocumentSettings
{
  private Twips? GetTwips<ElementType>() where ElementType : DX.OpenXmlElement
  {
    if (_DocumentSettings != null)
    {
      var _element = _DocumentSettings?.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        if (_element is DXW.TwipsMeasureType twipsMeasure)
        {
          var str = twipsMeasure.Val?.Value;
          if (str != null)
            return new Twips(str);
        }
        if (_element is DXW.NonNegativeShortType nonNegativeShort)
        {
          var n = nonNegativeShort.Val?.Value;
          if (n != null)
            return new Twips((short)n);
        }
        else
          throw new InvalidDataException($"Unsupported twips conversion from type {_element.GetType()}");
      }
    }
    return null;
  }

  private void SetTwips<ElementType>(Twips? value) where ElementType : DX.OpenXmlElement
  {
    if (value is not null)
    {
      var _element = _ExistingSettings.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        if (_element is DXW.TwipsMeasureType twipsMeasure)
          twipsMeasure.Val = (string)value;
        else
        if (_element is DXW.NonNegativeShortType nonNegativeShort)
          nonNegativeShort.Val = (short)value;
        else
          throw new InvalidDataException($"Unsupported twips conversion to type {_element.GetType()}");
      }
    }
    else
    {
      var _element = _ExistingSettings.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  private ObjectType? GetObject<ObjectType, ElementType>() where ObjectType : class
    where ElementType : DX.OpenXmlElement
  {
    if (_DocumentSettings != null)
    {
      var _element = _DocumentSettings.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var constructor = typeof(ObjectType).GetConstructor(new Type[] { typeof(DX.OpenXmlElement) });
        Debug.Assert(constructor != null, $"Type {typeof(ObjectType)} must have constructor with OpenXmlElement parameter");
        return (ObjectType)constructor.Invoke(new object[] { _element });
      }
    }
    return null;
  }

  private void SetObject<ObjectType, ElementType>(ObjectType? value) where ObjectType : class, IOpenXmlElementMappedObject
  where ElementType : DX.OpenXmlElement
  {
    if (value != null)
    {
      var _element = _ExistingSettings.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var _newElement = value.GetElement<ElementType>();
        if (_element != _newElement)
        {
          _element.Remove();
          _ExistingSettings.AddChild(_newElement);
        }
      }
      else
        _ExistingSettings.AddChild(value.GetElement<ElementType>());
    }
    else
    {
      var setting = _ExistingSettings.Elements<ElementType>().FirstOrDefault();
      if (setting != null)
        setting.Remove();
    }
  }

  private EnumType? GetEnum<EnumType, ElementType>() where EnumType : struct, IConvertible
  where ElementType : DX.OpenXmlLeafElement
  {
    if (_DocumentSettings != null)
    {
      var _element = _DocumentSettings.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(ElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
        var val = valProperty.GetValue(_element);
        Debug.Assert(val != null, $"\"Val\" property in {typeof(ElementType)} is null");
        var valType = val.GetType();
      }
    }
    return null;
  }
}
