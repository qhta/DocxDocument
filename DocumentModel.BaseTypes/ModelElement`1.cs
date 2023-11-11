namespace DocumentModel;

/// <summary>
/// Base class for all model elements. 
/// Defines <see cref="Parent"/> property and <see cref="Equals"/> method.
/// </summary>
public class ModelElement<OpenXmlElementType> : ModelElement, IModelElement<OpenXmlElementType>, IOpenXmlElementMappedObject where OpenXmlElementType : DX.OpenXmlElement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public ModelElement()
  {
  }

  public ModelElement(DX.OpenXmlElement openXmlElement)
  {
    _Element = (OpenXmlElementType)openXmlElement;
  }

  public OpenXmlElementType1 GetElement<OpenXmlElementType1>() where OpenXmlElementType1 : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType1 validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {typeof(OpenXmlElementType1)} type supported in GetElement of {this.GetType()}");
  }

  public ModelElement(OpenXmlElementType openXmlElement)
  {
    _Element = openXmlElement;
  }

  public OpenXmlElementType? _Element { get; set; }

  public OpenXmlElementType _ExistingElement
  {
    get
    {
      if (_Element == null)
      {
        var constructor = typeof(OpenXmlElementType).GetConstructor(new Type[]{ });
        if (constructor == null)
          throw new InvalidOperationException($"'{typeof(OpenXmlElementType)}' must be a non-abstract type with a public parameterless constructor");
        _Element = (OpenXmlElementType)constructor.Invoke(new object[]{ });
      }
      return _Element;
    }
    private set => _Element = value;
  }

}