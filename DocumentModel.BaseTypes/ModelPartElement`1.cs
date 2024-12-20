﻿namespace DocumentModel;

/// <summary>
/// Base class for all model elements. 
/// Defines <see cref="Parent"/> property and <see cref="Equals"/> method.
/// </summary>
public class ModelPartElement<OpenXmlPartType> : ModelElement, IOpenXmlElementMappedObject where OpenXmlPartType : DXPack.OpenXmlPart
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public ModelPartElement()
  {
  }

  public ModelPartElement(DXPack.OpenXmlPart openXmlElement)
  {
    _Element = (OpenXmlPartType)openXmlElement;
  }

  public OpenXmlElementType1 GetElement<OpenXmlElementType1>() where OpenXmlElementType1 : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType1 validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {typeof(OpenXmlElementType1)} type supported in GetElement of {this.GetType()}");
  }

  public ModelPartElement(OpenXmlPartType openXmlElement)
  {
    _Element = openXmlElement;
  }

  public OpenXmlPartType? _Element { get; set; }

  public OpenXmlPartType _ExistingElement
  {
    get
    {
      if (_Element == null)
      {
        var constructor = typeof(OpenXmlPartType).GetConstructor(new Type[]{ });
        if (constructor == null)
          throw new InvalidOperationException($"'{typeof(OpenXmlPartType)}' must be a non-abstract type with a public parameterless constructor");
        _Element = (OpenXmlPartType)constructor.Invoke(new object[]{ });
      }
      return _Element;
    }
    private set => _Element = value;
  }

}