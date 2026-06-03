using System.Xml.Linq;

namespace DocumentModel.Interop;


/// <summary>
/// Model element that represents a document in the document model.
/// </summary>
public class DocumentElement: ModelElement
{
  /// <summary>
  /// Gets the Document object associated with this document element.
  /// </summary>
  public Document Document { get; internal set; }

}