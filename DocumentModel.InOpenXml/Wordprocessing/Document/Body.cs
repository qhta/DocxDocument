namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the contents of the body of the document, which serves as the main document editing surface in a WordprocessingML document.
/// The document body contains block-level markup, allowing elements such as paragraphs, tables, and other block content to exist as siblings within the document structure.
/// </summary>
[XmlRoot("Body", Namespace = "DocumentModel.Wordprocessing")]
public class Body : AbstractBody<DXW.Body>
{
  /// <summary>
  /// Default constructor for the Body class, initializing a new instance of the Body class.
  /// </summary>
  public Body() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the Body class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent ModelElement that will contain this Body instance. Cannot be null.</param>
  public Body(ModelElement parent) : base(parent)
  {
  }

  /// <summary>
  /// Constructor for the Body class that initializes a new instance based on an existing OpenXml Body element.
  /// </summary>
  /// <param name="openXmlBody">The OpenXml Body element to initialize the Body class with.</param>
  public Body(DXW.Body openXmlBody) : base(openXmlBody)
  {
  }
}