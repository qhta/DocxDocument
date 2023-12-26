using System.Xml.Serialization;

namespace DocumentModel;

/// <summary>
/// Base class for all model elements. 
/// Defines <see cref="Parent"/> property and <see cref="Equals"/> method.
/// </summary>
public class ModelElement<ElementType> : ModelElement, IModelElement<ElementType>, IOpenXmlElementMappedObject /*where OpenXmlElementType : DX.OpenXmlElement*/
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public ModelElement()
  {
  }

  public ModelElement (object openXmlElement)
  {
    _Element = (ElementType)openXmlElement;
  }

  public OpenXmlElementType1? GetElement<OpenXmlElementType1>() where OpenXmlElementType1 : DX.OpenXmlElement
  {
    if (typeof(OpenXmlElementType1)==typeof(ElementType))
      return _Element as OpenXmlElementType1;
    throw new ArgumentException($"Only {typeof(OpenXmlElementType1)} type is supported in GetElement of {this.GetType()}");
  }

  public ModelElement(ElementType openXmlElement)
  {
    _Element = openXmlElement;
  }

  [XmlIgnore]
  public ElementType? _Element { get; set; }

  [XmlIgnore]
  public ElementType _ExistingElement
  {
    get
    {
      if (_Element == null)
      {
        var constructor = typeof(ElementType).GetConstructor(new Type[]{ });
        if (constructor == null)
          throw new InvalidOperationException($"'{typeof(ElementType)}' must be a non-abstract type with a public parameterless constructor");
        _Element = (ElementType)constructor.Invoke(new object[]{ });
      }
      return _Element;
    }
    private set => _Element = value;
  }

}