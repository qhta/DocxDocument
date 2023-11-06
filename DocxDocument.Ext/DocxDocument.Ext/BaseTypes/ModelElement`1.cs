using DocumentFormat.OpenXml.Office2019.Excel.RichData2;

namespace DocumentModel;

/// <summary>
/// Base class for all model elements. 
/// Defines <see cref="Parent"/> property and <see cref="Equals"/> method.
/// </summary>
public class ModelElement<OpenXmlElementType> : ModelElement, IOpenXmlElementMappedObject where OpenXmlElementType: DX.OpenXmlElement, new()
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
   public ModelElement()
  {
    _Element = new OpenXmlElementType();
  }

  public ModelElement(DX.OpenXmlElement openXmlElement)
  {
    _Element = (OpenXmlElementType)openXmlElement;
  }

  public OpenXmlElementType1 GetElement<OpenXmlElementType1>() where OpenXmlElementType1 : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType1 validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public ModelElement(OpenXmlElementType openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal OpenXmlElementType _Element { get; set; }



}