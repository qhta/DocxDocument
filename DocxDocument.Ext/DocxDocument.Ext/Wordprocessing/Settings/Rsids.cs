namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the set of revision save ID values for the current document. 
/// Revision save ID values refer to four digit hexadecimal values which uniquely identify an editing session in the life of the current document. 
/// An editing session is the period of time between two subsequent save operations by an application.
/// [Guidance: The set of revision save IDs stored with a document only supplies information about the editing session 
/// in which document components were last saved, which can be used by applications in any manner desired. end guidance]
/// </summary>
public partial class Rsids: IOpenXmlElementMappedObject
{
  public Rsids()
  {
    _Element = new DXW.Rsids();
  }

  public Rsids(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.Rsids)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public Rsids(DXW.Rsids openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.Rsids _Element { get; private set; }

  /// <summary>
  /// Specifies the revision save ID which was associated with the first editing session for this document. 
  /// [Note: This information must be identical between any number of copies of the same document, 
  /// as they all originate from the same original editing session. Applications can use this information as desired. end note]
  /// </summary>
  [DataMember]
  public HexInt? RsidRoot
  {
    get => _Element.GetHexIntVal<DXW.RsidRoot>();
    set => _Element.SetHexIntVal<DXW.RsidRoot>(value);
  }
}
