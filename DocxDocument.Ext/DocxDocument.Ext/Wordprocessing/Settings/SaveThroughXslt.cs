namespace DocumentModel.Wordprocessing;

  /// <summary>
  ///  This element specifies the location of a custom XSL transform which shall be used 
  ///  when this document is saved as a single XML file (in a format not defined by /IEC 29500). 
  ///  [Guidance: Because this setting specifies behavior when saving to an alternative file format not defined by /IEC 29500, 
  ///  this behavior is optional. end guidance]
  /// </summary>
[DataContract]
public partial class SaveThroughXslt: IOpenXmlElementMappedObject
{
  public SaveThroughXslt()
  {
    _Element = new DXW.SaveThroughXslt();
  }

  public SaveThroughXslt(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.SaveThroughXslt)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public SaveThroughXslt(DXW.SaveThroughXslt openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.SaveThroughXslt _Element { get; private set; }

  [DataMember]
  public string? Id
  {
    get => _Element.Id?.Value;
    set => _Element.Id = value;
  }

  [DataMember]
  public string? SolutionId
  {
    get => _Element.SolutionId?.Value;
    set => _Element.SolutionId = value;
  }

}
