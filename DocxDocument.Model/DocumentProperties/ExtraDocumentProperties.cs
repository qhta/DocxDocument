using DocxDocument.Reader;

using Qhta.OpenXMLTools;

namespace DocxDocument.Model;

public class ExtraDocumentProperties: DocxBasedElement<WD.Settings>, IExtraDocumentProperties
{
  public ExtraDocumentProperties(WD.Settings element) : base(element)
  {
  }

  /// <summary> 
  /// A LongHexNumber element that specifies an arbitrary identifier for the context of the paragraph identifiers in the document.
  /// Values MUST be greater than 0 and less than 0x80000000.
  ///</summary> 
  public HexInt? DocumentId
  {
    get => DocxElement.ReadHexInt<W14.DocumentId>();
    set => DocxElement.WriteHexInt<W14.DocumentId>(value);
  }

  /// <summary> 
  /// Specifies a unique identifier for a set of documents derived from a common source.
  ///</summary> 
  public Guid? PersistentDocumentId
  {
    get => DocxElement.ReadGuid<W15.PersistentDocumentId>();
    set => DocxElement.WriteGuid<W15.PersistentDocumentId>(value);
  }

  /// <summary> 
  /// When true, specifies that the user was resolving conflicting edits when the document was saved.
  ///</summary> 
  public bool? ConflictMode
  {
    get => DocxElement.ReadW14OnOffType<W14.ConflictMode>();
    set => DocxElement.WriteW14OnOffType<W14.ConflictMode>(value);
  }

}