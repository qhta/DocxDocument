namespace DocumentModel.Wordprocessing;

/// <summary>
/// This is a collection of <see cref="CompatibilitySetting"/> items. 
/// It has no corresponding DocumentFormat.OpenXml.Wordprocessing class.
/// Instead items of DocumentFormat.OpenXml.Wordprocessing.CompatiblitySetting type 
/// are included directly in DocumentFormat.OpenXml.Wordprocessing.Compatibility element.
/// </summary>
public partial class CompatibilitySettings//: IOpenXmlElementMappedObject
{
  //public CompatibilitySettings()
  //{
  //  _Element = new DXW.Compatibility();
  //}

  //public CompatibilitySettings(DX.OpenXmlElement openXmlElement)
  //{
  //  _Element = (DXW.Compatibility)openXmlElement;
  //}

  //public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  //{
  //  if (_Element is OpenXmlElementType validTypeElement)
  //    return validTypeElement;
  //  throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  //}

  public CompatibilitySettings(DXW.Compatibility openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.Compatibility _Element { get; private set; }
}
