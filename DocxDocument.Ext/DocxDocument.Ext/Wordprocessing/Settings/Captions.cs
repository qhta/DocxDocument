namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the presence of information about captions in a given WordprocessingML document. 
/// This information is divided into two components:
/// <list type="bullet">
///   <item>The child elements Caption defines the format for a single type of caption to be automatically added to the document.</item>
///   <item>The child element AutoCaptions defines the types of objects to which a caption format shall automatically be applied.</item>
/// </list>
///  This information should be used to determine the captions which are automatically added to objects when they are inserted into a WordprocessingML document. [Note: This setting is typically ignored unless it is specified in an application's default template. end note]
/// </summary>
public partial class Captions: IOpenXmlElementMappedObject
{
  public Captions()
  {
    _Element = new DXW.Captions();
  }

  public Captions(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.Captions)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public Captions(DXW.Captions openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.Captions _Element { get; private set; }
}
