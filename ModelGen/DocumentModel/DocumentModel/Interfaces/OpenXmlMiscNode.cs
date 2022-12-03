namespace DocumentModel;

/// <summary>
/// Represents an Open XML non element node (i.e. PT, Comments, Entity, Notation, XmlDeclaration).
/// </summary>
public interface OpenXmlMiscNode // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Gets the type of XML node.
  /// </summary>
  public XmlNodeType? XmlNodeType { get ; set; }
  
}
