namespace DocumentModel;

/// <summary>
/// Represents an Open XML non element node (i.e. PT, Comments, Entity, Notation, XmlDeclaration).
/// </summary>
public interface IOpenXmlMiscNode // : DocumentModel.IOpenXmlElement
{
  /// <summary>
  /// Gets the type of XML node.
  /// </summary>
  public System.Xml.XmlNodeType? XmlNodeType { get ; set; }
  
}
